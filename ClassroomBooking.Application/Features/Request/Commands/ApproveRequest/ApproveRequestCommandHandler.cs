using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;
using static ClassroomBooking.Application.Features.Request.Constants.KeyRequestConstants;

namespace ClassroomBooking.Application.Features.Request.Commands.ApproveRequest;

public sealed class ApproveRequestCommandHandler: IRequestHandler<ApproveRequestCommand>
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

        if (request.ForceConfirmation)
        {
            await _requestRepository.RejectRequestsAsync(await _requestRepository.GetOverlappingAsync(keyRequest));
        }
        
        else if (!await _requestRepository.IsDateRangeValidForRequestAsync(keyRequest))
            throw new BadRequestException($"Request with id={keyRequest.Id} can't be approved");
        
        keyRequest.Status = RequestStatus.Accepted;

        if (keyRequest.EndDateOfRecurrence == null)
        {
            await _requestRepository.UpdateAsync(keyRequest);
            return;
        }
        
        var keyRequests = new List<KeyRequest>();
        
        for (var i = DateOnly.FromDateTime(keyRequest.StartDate).AddDays(NumberOfDaysInAWeek); i <= keyRequest.EndDateOfRecurrence; i = i.AddDays(NumberOfDaysInAWeek))
        {
            keyRequests.Add(new KeyRequest
            {
                StartDate = DateTime.SpecifyKind(i.ToDateTime(TimeOnly.FromTimeSpan(keyRequest.StartDate.TimeOfDay)), DateTimeKind.Utc),
                EndDate = DateTime.SpecifyKind(i.ToDateTime(TimeOnly.FromTimeSpan(keyRequest.EndDate.TimeOfDay)), DateTimeKind.Utc),
                ClassroomId = keyRequest.ClassroomId,
                UserId = keyRequest.UserId,
                Status = RequestStatus.Accepted,
            });
        }
        
        keyRequest.EndDateOfRecurrence = null;
            
        await _requestRepository.AddEntitiesAsync(keyRequests);
    }
}