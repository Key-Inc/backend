﻿using AutoMapper;
using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Enums;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;
using static ClassroomBooking.Application.Features.Request.Constants.KeyRequestConstants;

namespace ClassroomBooking.Application.Features.Request.Queries.GetSchedule;

public sealed class GetScheduleQueryHandler: IRequestHandler<GetScheduleQuery, IEnumerable<ScheduleDto>>
{
    private readonly IMapper _mapper;
    private readonly IKeyRequestRepository _requestRepository;
    private readonly IClassroomRepository _classroomRepository;

    public GetScheduleQueryHandler(IMapper mapper, IKeyRequestRepository requestRepository, IClassroomRepository classroomRepository)
    {
        _mapper = mapper;
        _requestRepository = requestRepository;
        _classroomRepository = classroomRepository;
    }

    public async Task<IEnumerable<ScheduleDto>> Handle(GetScheduleQuery request, CancellationToken cancellationToken)
    {
        var classroom = await _classroomRepository.GetByIdAsync(request.ClassroomId);
        if (classroom == null) throw new NotFoundException(nameof(Classroom), request.ClassroomId);

        var requests = await _requestRepository.GetSchedule(request.Date, request.ClassroomId);
        var scheduleBusyTime = _mapper.Map<List<ScheduleDto>>(requests);
        var result = new List<ScheduleDto>();
        
        if (scheduleBusyTime.Count == 0)
        {
            result.Add(new ScheduleDto
            {
                StartDate = new TimeOnly(MinPossibleStartTime.Ticks),
                EndDate = new TimeOnly(MaxPossibleEndTime.Ticks), 
                Status = ScheduleStatus.Available
            });
            
            return result;
        }
        
        if (scheduleBusyTime[0].StartDate > new TimeOnly(MinPossibleStartTime.Ticks))
        {
            result.Add(new ScheduleDto
            {
                StartDate = new TimeOnly(MinPossibleStartTime.Ticks),
                EndDate = scheduleBusyTime[0].StartDate, 
                Status = ScheduleStatus.Available
            });
            result.Add(scheduleBusyTime[0]);
        }

        for (int i = 1; i < scheduleBusyTime.Count; i++)
        {
            if (scheduleBusyTime[i - 1].EndDate != scheduleBusyTime[i].StartDate)
            {
                result.Add(new ScheduleDto
                {
                    StartDate = scheduleBusyTime[i - 1].EndDate,
                    EndDate = scheduleBusyTime[i].StartDate, 
                    Status = ScheduleStatus.Available
                });
                result.Add(scheduleBusyTime[i]);
            }
        }

        if (scheduleBusyTime[^1].EndDate < new TimeOnly(MaxPossibleEndTime.Ticks))
        {
            result.Add(new ScheduleDto
            {
                StartDate = scheduleBusyTime[^1].EndDate,
                EndDate = new TimeOnly(MaxPossibleEndTime.Ticks), 
                Status = ScheduleStatus.Available
            });
        }
        
        
        return result;
    }
}