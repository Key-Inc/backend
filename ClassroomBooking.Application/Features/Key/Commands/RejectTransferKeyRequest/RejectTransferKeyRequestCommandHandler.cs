using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Application.Features.Key.Commands.RejectTransferKeyRequest;

public sealed class RejectTransferKeyRequestCommandHandler : IRequestHandler<RejectTransferKeyRequestCommand>
{
    private readonly ITransferKeyRequestRepository _transferKeyRequestRepository;

    public RejectTransferKeyRequestCommandHandler(ITransferKeyRequestRepository transferKeyRequestRepository)
    {
        _transferKeyRequestRepository = transferKeyRequestRepository;
    }

    public async Task Handle(RejectTransferKeyRequestCommand request, CancellationToken cancellationToken)
    {
        var transferRequest = await _transferKeyRequestRepository.Entities
            .FirstOrDefaultAsync(req =>
                req.RecipientId == request.UserId && req.KeyId == request.KeyId &&
                req.Status == RequestStatus.UnderConsideration, cancellationToken: cancellationToken);
        
        if (transferRequest == null) 
            throw new NotFoundException($"The request under consideration to transfer the key ({request.KeyId}) was not found");

        transferRequest.Status = RequestStatus.Rejected;
        await _transferKeyRequestRepository.UpdateAsync(transferRequest);
    }
}