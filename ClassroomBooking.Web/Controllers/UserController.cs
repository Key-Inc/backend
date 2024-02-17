using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Web.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class UserController : BaseController
{
    public UserController(IMediator mediator) : base(mediator) {}
    
    [HttpGet]
    public async Task<ActionResult<UserPagedListDto>> GetUserList([FromQuery] UserSearchParameters searchParameters)
    {
        throw new NotImplementedException();
    }
}