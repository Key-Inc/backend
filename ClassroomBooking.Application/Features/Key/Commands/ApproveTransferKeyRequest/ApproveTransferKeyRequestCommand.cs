using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.ApproveTransferKeyRequest;

public sealed record ApproveTransferKeyRequestCommand(Guid UserId, Guid KeyId) : IRequest;