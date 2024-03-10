using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.Common.ValidationAttributes;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class UserEditDto
{
    [DateLessThanToday]
    public DateOnly? BirthDate { get; set; }
    
    [PhoneNumber]
    public string? PhoneNumber { get; set; }
    
    [MinLength(1)]
    [MaxLength(100)]
    [EmailAddress]
    public string? Email { get; set; }
    
    [MinLength(6)]
    [MaxLength(100)]
    public string? Password { get; set; }
}   