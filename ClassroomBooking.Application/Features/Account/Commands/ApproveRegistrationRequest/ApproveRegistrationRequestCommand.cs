using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.ApproveRegistrationRequest;

public sealed record ApproveRegistrationRequestCommand(
    Guid UserId, 
    Guid ApplicantId, 
    UserRole ApplicantRole) : IRequest;