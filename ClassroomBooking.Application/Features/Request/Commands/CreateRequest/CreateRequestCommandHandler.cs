﻿using ClassroomBooking.Application.Common.Exceptions;
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
        
        if (requestDto.StartDate.Date < DateTime.Now.Date)
        {
            throw new BadRequestException("Start date can't be less than today");
        }
        
        if (requestDto.StartDate > requestDto.EndDate || requestDto.StartDate == requestDto.EndDate || requestDto.StartDate.Date != requestDto.EndDate.Date ||
            requestDto.StartDate.TimeOfDay < MinPossibleStartTime || requestDto.EndDate.TimeOfDay > MaxPossibleEndTime)
            throw new BadRequestException("Invalid date range");
        
        if (!(requestDto.EndDateOfRecurrence == null || 
              requestDto.EndDate <= requestDto.EndDateOfRecurrence?.ToDateTime(TimeOnly.MaxValue)))
        {
            throw new BadRequestException("Invalid booking recurrence range");
        }
        
        var user = await _userRepository.GetByIdAsync(request.UserId);
        if (user == null) throw new UserNotFoundException(request.UserId);
        if (user.UserRole == UserRole.Student && requestDto.EndDateOfRecurrence != null) throw new ForbiddenException(user.Id);
        
        var classroom = await _classroomRepository.GetByIdAsync(requestDto.ClassroomId);
        if (classroom == null) throw new NotFoundException(nameof(Classroom), requestDto.ClassroomId);
        
        if (user.UserRole == UserRole.Student && !await _requestRepository.IsDateRangeValidAsync(requestDto.StartDate, 
                requestDto.EndDate,
                requestDto.ClassroomId)) throw new BadRequestException("Time is already taken");
        
        var keyRequest = new KeyRequest
        {
            StartDate = requestDto.StartDate,
            EndDate = requestDto.EndDate,
            ClassroomId = requestDto.ClassroomId,
            UserId = request.UserId,
            Status = RequestStatus.UnderConsideration,
            EndDateOfRecurrence = requestDto.EndDateOfRecurrence
        };

        await _requestRepository.AddAsync(keyRequest);
    }
}