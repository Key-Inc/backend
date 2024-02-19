using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Queries.GetOverlappingRequests;

public sealed record GetOverlappingRequestQuery(Guid RequestId): IRequest<IEnumerable<KeyRequestFullDto>>;