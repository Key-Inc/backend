using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Application.Features.Key.Commands.GiveKey;
using ClassroomBooking.Application.Features.Key.Commands.TakeKey;
using ClassroomBooking.Application.Features.Key.Commands.TransferKey;
using ClassroomBooking.Application.Features.Key.Queries.GetKeys;
using ClassroomBooking.Application.Features.Key.Queries.GetMyKeys;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Web.Controllers.Base;
using ClassroomBooking.Web.Filters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

[EnableCors("MyCors")]
public sealed class KeyController : BaseController
{
    public KeyController(IMediator mediator) : base(mediator) {}
    
    [HttpGet]
    [Authorize]
    [RequiresRole(UserRole.Dean)]
    public async Task<ActionResult<IEnumerable<KeyFullDto>>> GetKeys([FromQuery] KeyStatus? keyStatus)
    {
        var getKeysQuery = new GetKeysQuery(keyStatus);
        var keys = await Mediator.Send(getKeysQuery);
        return Ok(keys);
    }
    
    [HttpGet]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    [Route("my")]
    public async Task<ActionResult<IEnumerable<KeyDto>>> GetUserKeys()
    {
        var getMyKeysQuery = new GetMyKeysQuery(UserId);
        var keys = await Mediator.Send(getMyKeysQuery);
        return Ok(keys);
    }

    [HttpPut]
    [Authorize]
    [RequiresRole(UserRole.Dean)]
    [Route("{id:guid}/user/{userId:guid}/issued")]
    public async Task<IActionResult> IssuedKey(Guid id, Guid userId)
    {
        var giveKeyCommand = new GiveKeyCommand(id, userId);
        await Mediator.Send(giveKeyCommand);
        return Ok();
    }
    
    [HttpPut]
    [Authorize]
    [RequiresRole(UserRole.Dean)]
    [Route("{id:guid}/instock")]
    public async Task<IActionResult> InStockKey(Guid id)
    {
        var takeKeyCommand = new TakeKeyCommand(id);
        await Mediator.Send(takeKeyCommand);
        return Ok();
    }
    
    [HttpPut]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    [Route("{id:guid}/user/{userId:guid}/transfer")]
    public async Task<IActionResult> TransferRequest(Guid id, Guid userId)
    {
        var transferKeyCommand = new TransferKeyCommand(id,UserId, userId);
        await Mediator.Send(transferKeyCommand);
        return Ok();
    }
}