using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.RejectRequest;

public sealed class RejectRequestCommandHandler: IRequestHandler<RejectRequestCommand>
{
    private readonly IKeyRequestRepository _requestRepository;

    public RejectRequestCommandHandler(IKeyRequestRepository requestRepository)
    {
        _requestRepository = requestRepository;
    }

    public async Task Handle(RejectRequestCommand request, CancellationToken cancellationToken)
    {
        var keyRequest = await _requestRepository.GetByIdAsync(request.RequestId);
        if (keyRequest == null) throw new NotFoundException(nameof(KeyRequest), request.RequestId);
        
        if (keyRequest.Status == RequestStatus.Rejected)
            throw new BadRequestException($"Request with id={keyRequest.Id} has have been Reject");
        
        keyRequest.Status = RequestStatus.Rejected;

        await _requestRepository.UpdateAsync(keyRequest);
    }
}