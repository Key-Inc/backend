using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Queries.GetSchedule;

public sealed record GetScheduleQuery(Guid ClassroomId, DateTime Date, Guid UserId): IRequest<IEnumerable<ScheduleDto>>;
