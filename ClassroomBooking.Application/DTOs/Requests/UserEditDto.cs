using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class UserEditDto
{
    public DateOnly? BirthDate { get; set; }
    public string? PhoneNumber { get; set; }
    
    [MinLength(1)]
    [MaxLength(100)]
    [EmailAddress]
    public string? Email { get; set; }
    
    [MinLength(6)]
    [MaxLength(100)]
    public string? Password { get; set; }
}   