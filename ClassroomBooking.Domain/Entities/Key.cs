using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class Key: BaseEntity
{
    public required KeyStatus KeyStatus { get; set; }
    public required int ClassroomNumber { get; set; }
    public User? User { get; set; }
}