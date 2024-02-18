using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.GiveKey;

public sealed record GiveKeyCommand(Guid KeyId, Guid UserId): IRequest;