using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.ApproveRequest;

public sealed record ApproveRequestCommand(Guid RequestId): IRequest;