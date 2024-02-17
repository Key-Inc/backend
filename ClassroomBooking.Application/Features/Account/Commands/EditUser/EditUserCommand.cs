using ClassroomBooking.Application.DTOs.Requests;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.EditUser;

public sealed record EditUserCommand(Guid UserId, UserEditDto UserEdit) : IRequest;