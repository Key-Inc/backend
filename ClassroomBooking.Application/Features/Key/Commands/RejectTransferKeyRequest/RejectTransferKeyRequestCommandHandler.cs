using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

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
        var transferRequest = await _transferKeyRequestRepository.GetByRecipientIdAndKeyId(request.UserId, request.KeyId);
        if (transferRequest == null) 
            throw new NotFoundException($"The request to transfer the key ({request.KeyId}) was not found");

        transferRequest.Status = RequestStatus.Rejected;
        await _transferKeyRequestRepository.UpdateAsync(transferRequest);
    }
}