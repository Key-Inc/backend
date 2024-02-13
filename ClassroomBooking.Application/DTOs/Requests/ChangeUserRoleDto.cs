using ClassroomBooking.Domain.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class ChangeUserRoleDto
{
    public required Guid UserId { get; set; }
    public required UserRole Role { get; set; }
}