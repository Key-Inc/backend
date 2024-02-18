using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Queries.GetMyKeys;

public sealed record GetMyKeysQuery(Guid UserId) : IRequest<IEnumerable<KeyDto>>;
