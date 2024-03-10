using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class TransferKeyRequestSearchParameters : PaginationParameters
{
    public string? ApplicantName { get; set; }
    public RequestStatus? Status { get; set; }
}