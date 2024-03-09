using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Application.Features.Classroom.Queries.GetClassrooms;
using ClassroomBooking.Web.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class ClassroomController : BaseController
{
    public ClassroomController(IMediator mediator) : base(mediator) {}

    [HttpGet]
    public async Task<ActionResult<ClassroomPagedListDto>> GetClassroomList(
        [FromQuery] ClassroomSearchParameters searchParameters)
    {
        var getClassroomsQuery = new GetClassroomsQuery(searchParameters);
        var classrooms = await Mediator.Send(getClassroomsQuery);
        return Ok(classrooms);
    }
}