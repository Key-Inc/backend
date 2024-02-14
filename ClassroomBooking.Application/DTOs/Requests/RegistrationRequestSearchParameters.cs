using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.DTOs.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class RegistrationRequestSearchParameters : PaginationParameters
{
    public string? Gender { get; set; }
    
    public string? FullName { get; set; }
    
    [Range(0, int.MaxValue)]
    public int? MinAge { get; set; }
    
    [Range(0, int.MaxValue)]
    public int? MaxAge { get; set; }
    
    public RegistrationRequestSorting? Sorting { get; set; }
}