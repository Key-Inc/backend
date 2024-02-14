using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class UserDto
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    [MinLength(1)]
    public required string FullName { get; set; }
    
    public DateTime? BirthDate { get; set; }
    
    [Required]
    public Gender Gender { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    [Required]
    [MinLength(1)]
    [EmailAddress]
    public required string Email { get; set; }
    
    public UserRole? UserRole { get; set; }
}