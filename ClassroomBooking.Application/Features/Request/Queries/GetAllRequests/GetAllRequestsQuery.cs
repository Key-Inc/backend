using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Queries.GetAllRequests;

public sealed record GetAllRequestsQuery(KeyRequestSearchParameters SearchParameters) 
    : IRequest<PagedListDto<KeyRequestFullDto>>;