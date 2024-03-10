using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class User : BaseEntity
{
    public required string FullName { get; set; }
    public DateOnly? BirthDate { get; set; }
    public required Gender Gender { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public string? PhoneNumber { get; set; }
    public UserRole? UserRole { get; set; }

    public IEnumerable<KeyRequest>? Requests { get; set; }
    public IEnumerable<TransferKeyRequest>? TransferKeyRequests { get; set; }
    public IEnumerable<TransferKeyRequest>? MyTransferKeyRequests { get; set; }
}