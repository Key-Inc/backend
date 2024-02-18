using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.TakeKey;

public sealed record TakeKeyCommand(Guid KeyId): IRequest;