namespace ClassroomBooking.Domain.Entities.Base;

public abstract class BaseEntity
{
    public Guid Id { get; init; }
    public DateTime CreateTime { get; init; }
}