using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class KeyRequestCreateDto
{
    [Required]
    public required DateTimeRangeDto BookingTime { get; set; }
    
    public DateOnlyRangeDto? BookingRecurrence { get; set; }
    
    [Required]
    public required Guid ClassroomId { get; set; }
}