using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class Key : BaseEntity
{
    public required KeyStatus KeyStatus { get; set; }
    public required int ClassroomNumber { get; set; }
    public IEnumerable<KeyRequest>? Requests { get; set; }

    public Guid? UserId { get; set; }
    public User? User { get; set; }
}