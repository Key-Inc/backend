using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Domain.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class UserEditDto
{
    public DateTime? BirthDate { get; set; }
    public string? PhoneNumber { get; set; }
    
    [MinLength(1)]
    [MaxLength(100)]
    [EmailAddress]
    public string? Email { get; set; }
}   