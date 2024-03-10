using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Application.Features.Key.Commands.TransferKey;

public class TransferKeyCommandHandler: IRequestHandler<TransferKeyCommand>
{
    private readonly IKeyRepository _keyRepository;
    private readonly ITransferKeyRequestRepository _transferKeyRequestRepository;

    public TransferKeyCommandHandler(
        IKeyRepository keyRepository, 
        ITransferKeyRequestRepository transferKeyRequestRepository)
    {
        _keyRepository = keyRepository;
        _transferKeyRequestRepository = transferKeyRequestRepository;
    }

    public async Task Handle(TransferKeyCommand request, CancellationToken cancellationToken)
    {
        var key = await _keyRepository.GetByIdAsync(request.KeyId);
        
        if (key == null) throw new NotFoundException(nameof(Domain.Entities.Key), request.KeyId);
        if (key.UserId != request.OwnerId) throw new BadRequestException($"User with id={request.OwnerId} is not owner");

        var requestIsExists = await _transferKeyRequestRepository.Entities
            .AnyAsync(transferRequest => transferRequest.RecipientId == request.UserId 
                                         && transferRequest.KeyId == request.KeyId, cancellationToken: cancellationToken);
        if (requestIsExists) throw new BadRequestException("The transfer request already exists");

        var transferRequest = new TransferKeyRequest
        {
            KeyId = request.KeyId,
            RecipientId = request.UserId,
            Status = RequestStatus.UnderConsideration
        };
        
        await _transferKeyRequestRepository.AddAsync(transferRequest);
    }
}