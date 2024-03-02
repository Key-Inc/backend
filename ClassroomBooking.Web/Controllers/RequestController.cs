using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Application.Features.Request.Commands.ApproveRequest;
using ClassroomBooking.Application.Features.Request.Commands.CreateRequest;
using ClassroomBooking.Application.Features.Request.Commands.DeleteMyRequest;
using ClassroomBooking.Application.Features.Request.Commands.RejectRequest;
using ClassroomBooking.Application.Features.Request.Queries.GetAllRequests;
using ClassroomBooking.Application.Features.Request.Queries.GetMyRequests;
using ClassroomBooking.Application.Features.Request.Queries.GetOverlappingRequests;
using ClassroomBooking.Application.Features.Request.Queries.GetSchedule;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Web.Controllers.Base;
using ClassroomBooking.Web.Filters;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class RequestController : BaseController
{
    public RequestController(IMediator mediator) : base(mediator) {}
    
    [HttpGet]
    [Route("{id:guid}/overlapping")]
    [Authorize]
    [RequiresRole(UserRole.Dean)]
    public async Task<ActionResult<IEnumerable<KeyRequestFullDto>>> GetOverlappingRequests(Guid id)
    {
        var query = new GetOverlappingRequestQuery(id);
        var keyRequests = await Mediator.Send(query);
        return Ok(keyRequests);
    } 
    
    [HttpGet]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    [Route("schedule")]
    public async Task<ActionResult<IEnumerable<ScheduleDto>>> GetSchedule(
        [FromQuery] ScheduleSearchParameters searchParameters)
    {
        var query = new GetScheduleQuery(searchParameters.ClassroomId, searchParameters.Date, UserId);
        var response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpGet]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    [Route("my")]
    public async Task<ActionResult<IEnumerable<KeyRequestDto>>> GetMyRequests()
    {
        var getMyRequests = new GetMyRequestsQuery(UserId);
        var requests = await Mediator.Send(getMyRequests);
        return Ok(requests);
    }

    [HttpGet]
    [RequiresRole(UserRole.Dean)]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult<PagedListDto<KeyRequestFullDto>>> GetKeyRequestList(
        [FromQuery] KeyRequestSearchParameters parameters)
    {
        var getAllRequestsQuery = new GetAllRequestsQuery(parameters);
        var pagedList = await Mediator.Send(getAllRequestsQuery);

        return Ok(pagedList);
    }

    [HttpPost]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    public async Task<IActionResult> CreateKeyRequest(KeyRequestCreateDto requestCreateDto)
    {
        var command = new CreateRequestCommand(requestCreateDto, UserId);
        await Mediator.Send(command);
        return Ok();
    }

    [HttpPut]
    [Route(("{id:guid}/approve"))]
    [Authorize]
    [RequiresRole(UserRole.Dean)]
    public async Task<IActionResult> AcceptRequest(Guid id)
    {
        var command = new ApproveRequestCommand(id);
        await Mediator.Send(command);
        return Ok();
    }

    [HttpPut]
    [Route("{id:guid}/reject")]
    [Authorize]
    [RequiresRole(UserRole.Dean)]
    public async Task<IActionResult> RejectRequest(Guid id)
    {
        var command = new RejectRequestCommand(id);
        await Mediator.Send(command);
        return Ok();
    }

    [HttpDelete]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    [Route("{id:guid}/delete")]
    public async Task<IActionResult> DeleteRequest(Guid id)
    {
        var deleteCommand = new DeleteMyRequestCommand(id, UserId);
        await Mediator.Send(deleteCommand);
        return Ok();
    }
}