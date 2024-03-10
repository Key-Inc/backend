using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Queries.GetRegistrationStatus;

public sealed record GetRegistrationStatusQuery(Guid UserId) : IRequest<RequestStatus>;