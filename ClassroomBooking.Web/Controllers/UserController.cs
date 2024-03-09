using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Application.Features.Users.Queries.GetUserList;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Web.Controllers.Base;
using ClassroomBooking.Web.Filters;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class UserController : BaseController
{
    public UserController(IMediator mediator) : base(mediator) {}
    
    [HttpGet]
    [RequiresRole(UserRole.Student)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult<PagedListDto<UserFullDto>>> GetUserList([FromQuery] UserSearchParameters searchParameters)
    {
        var getUserListQuery = new GetUserListQuery(searchParameters);
        var pagedList = await Mediator.Send(getUserListQuery);

        return Ok(pagedList);
    }
}