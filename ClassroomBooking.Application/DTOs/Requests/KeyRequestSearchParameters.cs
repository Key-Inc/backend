using ClassroomBooking.Application.DTOs.Enums;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class KeyRequestSearchParameters : PaginationParameters
{
    public DateTime? MinDate { get; set; }
    
    public DateTime? MaxDate { get; set; }
    
    public string? FullName { get; set; }

    public UserRole? Role { get; set; }
    
    public KeyRequestSorting? Sorting { get; set; }
}