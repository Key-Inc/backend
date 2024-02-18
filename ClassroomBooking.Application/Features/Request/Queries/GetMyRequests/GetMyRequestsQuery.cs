using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Queries.GetMyRequests;

public sealed record GetMyRequestsQuery(Guid UserId) : IRequest<IEnumerable<KeyRequestDto>>;
