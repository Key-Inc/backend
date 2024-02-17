using ClassroomBooking.Domain.Entities.Base;

namespace ClassroomBooking.Domain.Entities;

public sealed class Classroom : BaseEntity
{
    public required int Number { get; set; }
    public required int Building { get; set; }  
}