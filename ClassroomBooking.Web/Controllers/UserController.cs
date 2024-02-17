using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class UserController : BaseController
{
    [HttpGet]
    public async Task<ActionResult<UserPagedListDto>> GetUserList([FromQuery] UserSearchParameters searchParameters)
    {
        throw new NotImplementedException();
    }
}