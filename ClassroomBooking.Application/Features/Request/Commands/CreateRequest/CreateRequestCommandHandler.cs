using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.CreateRequest;

public sealed class CreateRequestCommandHandler: IRequestHandler<CreateRequestCommand>
{
    private static readonly TimeSpan MinPossibleStartTime = new TimeSpan(8, 0, 0);
    private static readonly TimeSpan MaxPossibleEndTime =  new TimeSpan(21, 0, 0);
    
    private readonly IKeyRequestRepository _requestRepository;
    private readonly IClassroomRepository _classroomRepository;
    
    public CreateRequestCommandHandler(IKeyRequestRepository requestRepository, IClassroomRepository classroomRepository)
    {
        _requestRepository = requestRepository;
        _classroomRepository = classroomRepository;
    }

    public async Task Handle(CreateRequestCommand request, CancellationToken cancellationToken)
    {
        var requestDto = request.RequestDto;

        if (requestDto.StartDate > requestDto.EndDate)
            throw new BadRequestException("End date can't be less than start date");

        if (requestDto.StartDate.Date != requestDto.EndDate.Date ||
            requestDto.StartDate.TimeOfDay < MinPossibleStartTime || requestDto.EndDate.TimeOfDay > MaxPossibleEndTime)
            throw new BadRequestException("Invalid date range");
        
        var classroom = await _classroomRepository.GetByIdAsync(requestDto.ClassroomId);
        if (classroom == null) throw new NotFoundException(nameof(Classroom), requestDto.ClassroomId);

        if (!await _requestRepository.IsDateRangeValidAsync(requestDto.StartDate, requestDto.EndDate,
                requestDto.ClassroomId)) throw new BadRequestException("Time is already taken");

        var response = new KeyRequest
        {
            StartDate = requestDto.StartDate,
            EndDate = requestDto.EndDate,
            IsRecurring = requestDto.IsRecurring,
            ClassroomId = requestDto.ClassroomId,
            UserId = request.UserId,
            Status = RequestStatus.UnderConsideration
        };

        await _requestRepository.AddAsync(response);
    }
}