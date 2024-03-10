using ClassroomBooking.Application.Common.Exceptions;
using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.ApproveTransferKeyRequest;

public sealed class ApproveTransferKeyRequestCommandHandler : IRequestHandler<ApproveTransferKeyRequestCommand>
{
    private readonly ITransferKeyRequestRepository _transferKeyRequestRepository;

    public ApproveTransferKeyRequestCommandHandler(ITransferKeyRequestRepository transferKeyRequestRepository)
    {
        _transferKeyRequestRepository = transferKeyRequestRepository;
    }
    
    public async Task Handle(ApproveTransferKeyRequestCommand request, CancellationToken cancellationToken)
    {
        var transferRequest = await _transferKeyRequestRepository.GetByRecipientIdAndKeyIdIncludingAll(request.UserId, request.KeyId);
        
        if (transferRequest == null) 
            throw new NotFoundException($"The request under consideration to transfer the key ({request.KeyId}) was not found");
        if (transferRequest.ApplicantId != transferRequest.Key!.UserId) throw new NotOwnerException(transferRequest.ApplicantId);
        
        transferRequest.Key!.UserId = request.UserId;
        transferRequest.Status = RequestStatus.Accepted;
        
        await _transferKeyRequestRepository.UpdateAsync(transferRequest);
    }
}