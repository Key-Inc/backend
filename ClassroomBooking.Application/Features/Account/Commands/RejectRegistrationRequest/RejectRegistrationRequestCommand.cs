using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.RejectRegistrationRequest;

public sealed record RejectRegistrationRequestCommand(Guid ApplicantId) : IRequest;