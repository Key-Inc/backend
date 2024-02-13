using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class LoginCredentialsDto
{
    [Required]
    [MinLength(1)]
    [MaxLength(100)]
    [EmailAddress]
    public required string Email { get; set; }
    
    [Required]
    [MinLength(1)]
    [MaxLength(100)]
    public required string Password { get; set; }
}