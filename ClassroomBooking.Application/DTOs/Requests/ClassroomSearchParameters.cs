namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class ClassroomSearchParameters : PaginationParameters
{
    public string? Query { get; set; }
}