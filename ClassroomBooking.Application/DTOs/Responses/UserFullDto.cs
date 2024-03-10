using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class UserFullDto : UserDto
{
    [Required]
    public required UserRole UserRole { get; set; }
}