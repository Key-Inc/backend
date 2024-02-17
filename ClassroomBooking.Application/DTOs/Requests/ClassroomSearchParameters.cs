namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class ClassroomSearchParameters : PaginationParameters
{
    public int? Number { get; set; }
    public int? Building { get; set; }
}