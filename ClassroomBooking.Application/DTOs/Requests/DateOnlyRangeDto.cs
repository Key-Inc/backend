using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Requests;

public class DateOnlyRangeDto
{
    [Required]
    public required DateOnly StartDate { get; set; }
    
    [Required]
    public required DateOnly EndDate { get; set; }
}