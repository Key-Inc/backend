﻿using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Application.Features.Key.Commands.ApproveTransferKeyRequest;
using ClassroomBooking.Application.Features.Key.Commands.GiveKey;
using ClassroomBooking.Application.Features.Key.Commands.RejectTransferKeyRequest;
using ClassroomBooking.Application.Features.Key.Commands.TakeKey;
using ClassroomBooking.Application.Features.Key.Commands.TransferKey;
using ClassroomBooking.Application.Features.Key.Queries.GetKeys;
using ClassroomBooking.Application.Features.Key.Queries.GetMyKeys;
using ClassroomBooking.Application.Features.Key.Queries.GetTransferKeyRequests;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Web.Controllers.Base;
using ClassroomBooking.Web.Filters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

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
    
    [HttpGet]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    [Route("transfer-requests")]
    public async Task<ActionResult<PagedListDto<TransferKeyRequestDto>>> GetTransferRequests(
        [FromQuery] TransferKeyRequestSearchParameters parameters)
    {
        var getTransferKeyRequestsQuery = new GetTransferKeyRequestsQuery(UserId, parameters);
        var pagedList = await Mediator.Send(getTransferKeyRequestsQuery);

        return Ok(pagedList);
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
    [Route("{id:guid}/reject-transfer")]
    public async Task<IActionResult> RejectTransferRequest(Guid id)
    {
        var rejectTransferKeyRequestCommand = new RejectTransferKeyRequestCommand(UserId, id);
        await Mediator.Send(rejectTransferKeyRequestCommand);

        return Ok();
    }
    
    [HttpPut]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    [Route("{id:guid}/approve-transfer")]
    public async Task<IActionResult> ApproveTransferRequest(Guid id)
    {
        var approveTransferKeyRequestCommand = new ApproveTransferKeyRequestCommand(UserId, id);
        await Mediator.Send(approveTransferKeyRequestCommand);

        return Ok();
    }
    
    [HttpPost]
    [Authorize]
    [RequiresRole(UserRole.Student)]
    [Route("{id:guid}/user/{userId:guid}/transfer")]
    public async Task<IActionResult> TransferRequest(Guid id, Guid userId)
    {
        var transferKeyCommand = new TransferKeyCommand(id, UserId, userId);
        await Mediator.Send(transferKeyCommand);
        return Ok();
    }
}