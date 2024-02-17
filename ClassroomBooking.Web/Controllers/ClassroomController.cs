using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class ClassroomController : BaseController
{
    [HttpGet]
    public async Task<ActionResult<ClassroomPagedListDto>> GetClassroomList(
        [FromQuery] ClassroomSearchParameters searchParameters)
    {
        throw new NotImplementedException();
    }
}