using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Application.Features.Request.Commands.ApproveRequest;
using ClassroomBooking.Application.Features.Request.Commands.CreateRequest;
using ClassroomBooking.Application.Features.Request.Commands.DeleteMyRequest;
using ClassroomBooking.Application.Features.Request.Commands.RejectRequest;
using ClassroomBooking.Application.Features.Request.Queries.GetMyRequests;
using ClassroomBooking.Application.Features.Request.Queries.GetOverlappingRequests;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Web.Controllers.Base;
using ClassroomBooking.Web.Filters;
using MediatR;
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
    [Route("schedule")]
    public async Task<ActionResult<IEnumerable<ScheduleDto>>> GetSchedule(
        [FromQuery] ScheduleSearchParameters searchParameters)
    {
        throw new NotImplementedException();
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
    public async Task<ActionResult<KeyRequestPagedListDto>> GetKeyRequestList(
        [FromQuery] KeyRequestSearchParameters parameters)
    {
        throw new NotImplementedException();
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