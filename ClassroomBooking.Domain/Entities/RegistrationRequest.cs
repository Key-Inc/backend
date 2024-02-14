using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class RegistrationRequest : BaseEntity
{
    public required Guid UserId { get; set; }
    public required RequestStatus Status { get; set; }
}