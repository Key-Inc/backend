using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.RejectRequest;

public sealed record RejectRequestCommand(Guid RequestId) : IRequest;

