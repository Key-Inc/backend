using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Queries.GetTransferKeyRequests;

public sealed record GetTransferKeyRequestsQuery(Guid RecipientId, TransferKeyRequestSearchParameters SearchParameters)
    : IRequest<PagedListDto<TransferKeyRequestDto>>;