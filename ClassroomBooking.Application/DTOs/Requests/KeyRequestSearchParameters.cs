using ClassroomBooking.Application.DTOs.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class KeyRequestSearchParameters: PaginationParameters
{
    public DateTime? MinDate { get; set; }
    
    public DateTime? MaxDate { get; set; }
    
    public string? FullName { get; set; }

    public KeyRequestRole? Role { get; set; }
    
    public KeyRequestSorting? Sorting { get; set; }
    
    public string? Gender { get; set; }
}