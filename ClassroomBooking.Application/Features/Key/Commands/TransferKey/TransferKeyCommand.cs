using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.TransferKey;

public sealed record TransferKeyCommand(Guid KeyId, Guid OwnerId ,Guid UserId): IRequest;
