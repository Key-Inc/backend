using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.ApproveRequest;

public sealed record ApproveRequestCommand(Guid RequestId, bool ForceConfirmation): IRequest;