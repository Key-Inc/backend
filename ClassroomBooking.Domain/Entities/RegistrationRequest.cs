using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class RegistrationRequest : BaseEntity
{
    public required RequestStatus Status { get; set; }
    
    public User? User { get; set; }
    public required Guid UserId { get; set; }
}