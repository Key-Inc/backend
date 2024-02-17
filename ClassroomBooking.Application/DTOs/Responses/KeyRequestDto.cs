using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class KeyRequestDto
{
    [Required]
    public required RequestStatus Status { get; set; }
    
    [Required]
    public required DateTime StartDate { get; set; }
    
    [Required]
    public required DateTime EndDate { get; set; }
    
    [Required]
    public required bool IsRecurring { get; set; }
    
    [Required]
    public required Guid UserId { get; set; }
    
    [Required]
    public required Guid ClassroomId { get; set; }
}