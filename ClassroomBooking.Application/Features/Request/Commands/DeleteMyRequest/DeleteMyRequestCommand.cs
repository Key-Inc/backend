using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.DeleteMyRequest;

public sealed record DeleteMyRequestCommand(Guid RequestId, Guid UserId): IRequest;