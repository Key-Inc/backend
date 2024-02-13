using ClassroomBooking.Domain.Entities.Base;

namespace ClassroomBooking.Domain.Entities;

public sealed class KeyRequest: BaseEntity
{
    public required Guid UserId { get; set; }
    public required Guid KeyId { get; set; }
    
    public User? User { get; set; }
    public Key? Key { get; set; }
}