using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class KeyRequest : BaseEntity
{
    public required RequestStatus Status { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required bool IsRecurring { get; set; }
    
    public User? User { get; set; }
    public required Guid UserId { get; set; }
    
    public Classroom? Classroom { get; set; }
    public required Guid ClassroomId { get; set; }
}