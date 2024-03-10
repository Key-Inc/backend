using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.RejectTransferKeyRequest;

public sealed record RejectTransferKeyRequestCommand(Guid UserId, Guid KeyId) : IRequest;