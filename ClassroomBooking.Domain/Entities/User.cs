using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class User: BaseEntity
{
    public required string FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    public required Gender Gender { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public string? PhoneNumber { get; set; }
    public UserRole UserRole { get; set; }
}