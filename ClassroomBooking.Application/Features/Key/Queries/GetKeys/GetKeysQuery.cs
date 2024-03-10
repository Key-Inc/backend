using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Queries.GetKeys;

public sealed record GetKeysQuery(KeyStatus? Status): IRequest<IEnumerable<KeyFullDto>>;