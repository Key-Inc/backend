using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class Key : BaseEntity
{
    public required KeyStatus KeyStatus { get; set; }

    public User? User { get; set; }
    public Guid? UserId { get; set; }
    
    public Classroom? Classroom { get; set; }
    public required Guid ClassroomId { get; set; }
}