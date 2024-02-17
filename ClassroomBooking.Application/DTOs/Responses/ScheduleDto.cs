using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.DTOs.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class ScheduleDto
{
    [Required]
    public required DateTime StartDate { get; set; }
    
    [Required]
    public required DateTime EndDate { get; set; }
    
    [Required]
    public required ScheduleStatus Status { get; set; }
}