using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class ScheduleSearchParameters
{
    [Required]
    public required Guid ClassroomId { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    public required DateTime Date { get; set; }
}