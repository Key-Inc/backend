using ClassroomBooking.Application.DTOs.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class RegistrationRequestSearchParameters : PaginationParameters
{
    public string? NameQuery { get; set; }
    public RegistrationRequestSorting? Sorting { get; set; }
}