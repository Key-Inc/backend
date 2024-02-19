using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.EditUserRole;

public sealed record EditUserRoleCommand(Guid UserId, Guid EditableUserId, UserRole Role) : IRequest;