using ClassroomBooking.Application.Common.Exceptions;
using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.Features.Request.Constants;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;
using static ClassroomBooking.Application.Features.Request.Constants.KeyRequestConstants;

namespace ClassroomBooking.Application.Features.Request.Commands.CreateRequest;

public sealed class CreateRequestCommandHandler: IRequestHandler<CreateRequestCommand>
{
    private readonly IKeyRequestRepository _requestRepository;
    private readonly IClassroomRepository _classroomRepository;
    private readonly IUserRepository _userRepository;
    
    public CreateRequestCommandHandler(IKeyRequestRepository requestRepository, IClassroomRepository classroomRepository, IUserRepository userRepository)
    {
        _requestRepository = requestRepository;
        _classroomRepository = classroomRepository;
        _userRepository = userRepository;
    }

    public async Task Handle(CreateRequestCommand request, CancellationToken cancellationToken)
    {
        var requestDto = request.RequestDto;
        
        if (requestDto.BookingTime.StartDate < DateTime.UtcNow || requestDto.BookingRecurrence?.StartDate.ToDateTime(new TimeOnly(0,0,0)) < DateTime.UtcNow)
        {
            throw new BadRequestException("Start date can't be less than today");
        }
        
        if (requestDto.BookingTime.StartDate > requestDto.BookingTime.EndDate)
            throw new BadRequestException("End date can't be less than start date");

        if (requestDto.BookingTime.StartDate.Date != requestDto.BookingTime.EndDate.Date ||
            requestDto.BookingTime.StartDate.TimeOfDay < MinPossibleStartTime || requestDto.BookingTime.EndDate.TimeOfDay > MaxPossibleEndTime)
            throw new BadRequestException("Invalid date range");
        
        if (!(requestDto.BookingRecurrence == null || 
              (requestDto.BookingTime.StartDate >= requestDto.BookingRecurrence.StartDate.ToDateTime(new TimeOnly(0,0,0)) 
               && requestDto.BookingTime.EndDate <= requestDto.BookingRecurrence.EndDate.ToDateTime(new TimeOnly(23,59,59)))))
        {
            throw new BadRequestException("Invalid booking recurrence range");
        }
        
        var user = await _userRepository.GetByIdAsync(request.UserId);
        if (user == null) throw new UserNotFoundException(request.UserId);
        
        var classroom = await _classroomRepository.GetByIdAsync(requestDto.ClassroomId);
        if (classroom == null) throw new NotFoundException(nameof(Classroom), requestDto.ClassroomId);
        
        if (user.UserRole == UserRole.Student && !await _requestRepository.IsDateRangeValidAsync(requestDto.BookingTime.StartDate, 
                requestDto.BookingTime.EndDate,
                requestDto.ClassroomId)) throw new BadRequestException("Time is already taken");

        if (requestDto.BookingRecurrence == null) {
            var keyRequest = new KeyRequest
            {
                StartDate = requestDto.BookingTime.StartDate,
                EndDate = requestDto.BookingTime.EndDate,
                ClassroomId = requestDto.ClassroomId,
                UserId = request.UserId,
                Status = RequestStatus.UnderConsideration
            };

            await _requestRepository.AddAsync(keyRequest);
            return;
        }

        var keyRequests = new List<KeyRequest>();
        
        for (var i = DateOnly.FromDateTime(requestDto.BookingTime.StartDate); i >= requestDto.BookingRecurrence.StartDate; i = i.AddDays(-NumberOfDaysInAWeek))
        {
            keyRequests.Add(new KeyRequest
            {
                StartDate = DateTime.SpecifyKind(i.ToDateTime(TimeOnly.FromTimeSpan(requestDto.BookingTime.StartDate.TimeOfDay)), DateTimeKind.Utc),
                EndDate = DateTime.SpecifyKind(i.ToDateTime(TimeOnly.FromTimeSpan(requestDto.BookingTime.EndDate.TimeOfDay)), DateTimeKind.Utc),
                ClassroomId = requestDto.ClassroomId,
                UserId = request.UserId,
                Status = RequestStatus.UnderConsideration
            });
        }
        
        for (var i = DateOnly.FromDateTime(requestDto.BookingTime.StartDate).AddDays(NumberOfDaysInAWeek); i <= requestDto.BookingRecurrence.EndDate; i = i.AddDays(NumberOfDaysInAWeek))
        {
            keyRequests.Add(new KeyRequest
            {
                StartDate = DateTime.SpecifyKind(i.ToDateTime(TimeOnly.FromTimeSpan(requestDto.BookingTime.StartDate.TimeOfDay)), DateTimeKind.Utc),
                EndDate = DateTime.SpecifyKind(i.ToDateTime(TimeOnly.FromTimeSpan(requestDto.BookingTime.EndDate.TimeOfDay)), DateTimeKind.Utc),
                ClassroomId = requestDto.ClassroomId,
                UserId = request.UserId,
                Status = RequestStatus.UnderConsideration
            });
        }

        await _requestRepository.AddEntitiesAsync(keyRequests);
    }
}