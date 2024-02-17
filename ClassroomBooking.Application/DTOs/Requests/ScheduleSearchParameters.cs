using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class ScheduleSearchParameters
{
    [DataType(DataType.Date)]
    public DateTime? Date { get; set; }
    
    public int? ClassroomNumber { get; set; }
}