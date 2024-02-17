using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Queries.GetUser;

public sealed record GetUserQuery(Guid UserId) : IRequest<UserDto>;