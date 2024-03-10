using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Queries.GetRole;

public sealed record GetRoleQuery(Guid UserId): IRequest<UserRole?>;