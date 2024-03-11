using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Users.Queries.GetUserList;

public sealed record GetUserListQuery(Guid UserId, UserSearchParameters SearchParameters) : IRequest<PagedListDto<UserFullDto>>;