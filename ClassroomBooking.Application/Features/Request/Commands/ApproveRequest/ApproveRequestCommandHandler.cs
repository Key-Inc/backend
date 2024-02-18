using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.ApproveRequest;

public class ApproveRequestCommandHandler: IRequestHandler<ApproveRequestCommand>
{
    private readonly IKeyRequestRepository _requestRepository;

    public ApproveRequestCommandHandler(IKeyRequestRepository requestRepository)
    {
        _requestRepository = requestRepository;
    }

    public async Task Handle(ApproveRequestCommand request, CancellationToken cancellationToken)
    {
        var keyRequest = await _requestRepository.GetByIdAsync(request.RequestId);
        if (keyRequest == null) throw new NotFoundException(nameof(KeyRequest), request.RequestId);

        if (keyRequest.Status == RequestStatus.Accepted)
            throw new BadRequestException($"Request with id={keyRequest.Id} has have been approved");
        
        if (!await _requestRepository.IsDateRangeValidForRequest(keyRequest))
            throw new BadRequestException($"Request with id={keyRequest.Id} can't be approved");
        
        keyRequest.Status = RequestStatus.Accepted;

        await _requestRepository.UpdateAsync(keyRequest);
    }
}