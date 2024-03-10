using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.Common.ValidationAttributes;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class KeyRequestCreateDto
{
    [Required]
    [DateLessThanToday]
    public required DateTime StartDate { get; set; }
    
    [Required]
    [DateLessThanToday]
    public required DateTime EndDate { get; set; }
    
    [DateLessThanToday]
    public DateOnly? EndDateOfRecurrence { get; set; }
    
    [Required]
    public required Guid ClassroomId { get; set; }
}