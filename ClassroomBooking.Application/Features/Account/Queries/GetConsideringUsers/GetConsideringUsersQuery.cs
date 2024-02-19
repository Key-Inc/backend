using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Queries.GetConsideringUsers;

public sealed record GetConsideringUsersQuery(RegistrationRequestSearchParameters SearchParameters) 
    : IRequest<PagedListDto<UserDto>>;