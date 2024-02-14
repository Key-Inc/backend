using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class UserRegisterDto
{
    [Required]
    [MinLength(1)]
    [MaxLength(100)]
    public required string FullName { get; set; }
    
    [Required]
    [MinLength(6)]
    [MaxLength(100)]
    public required string Password { get; set; }
    
    public DateTime? BirthDate { get; set; }
    
    [Required]
    public Gender Gender { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    [Required]
    [MinLength(1)]
    [MaxLength(100)]
    [EmailAddress]
    public required string Email { get; set; }
}