using ClassroomBooking.Domain.Entities.Base;

namespace ClassroomBooking.Domain.Entities;

public sealed class RegistrationRequest: BaseEntity
{
    public required Guid UserId { get; set; }
    public User? User { get; set; }
}