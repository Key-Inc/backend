namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class UserSearchParameters : PaginationParameters
{
    public string? NameQuery { get; set; }
}