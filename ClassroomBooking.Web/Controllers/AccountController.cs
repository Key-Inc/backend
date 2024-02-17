﻿using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Application.Features.Account.Commands.EditUser;
using ClassroomBooking.Application.Features.Account.Commands.Login;
using ClassroomBooking.Application.Features.Account.Commands.Register;
using ClassroomBooking.Application.Features.Account.Queries.GetUser;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Web.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class AccountController : BaseController
{
    public AccountController(IMediator mediator) : base(mediator) {}
    
    [HttpPost]
    [Route("register")]
    public async Task<ActionResult<TokenResponseDto>> Register(UserRegisterDto registerDto)
    {
        var registerCommand = new RegisterCommand(registerDto);
        var tokenResponse = await Mediator.Send(registerCommand);

        return Ok(tokenResponse);
    }

    [HttpPost]
    [Route("login")]
    public async Task<ActionResult<TokenResponseDto>> LogIn(LoginCredentialsDto credentials)
    {
        var loginCommand = new LoginCommand(credentials);
        var tokenResponse = await Mediator.Send(loginCommand);

        return Ok(tokenResponse);
    }

    [HttpGet]
    [Route("profile")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult<UserDto>> GetProfile()
    {
        var getUserQuery = new GetUserQuery(UserId);
        var userDto = await Mediator.Send(getUserQuery);

        return Ok(userDto);
    }

    [HttpGet]
    [Route("registration-status")]
    public async Task<ActionResult<RequestStatus>> GetRegistrationStatus()
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{userId:guid}/approve/")]
    public async Task<IActionResult> AcceptRegistrationRequest(Guid userId, [FromQuery] [Required] UserRole userRole)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{userId:guid}/reject")]
    public async Task<IActionResult> RejectRegistrationRequest(Guid userId)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("profile")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<IActionResult> EditProfile(UserEditDto editDto)
    {
        var editUserCommand = new EditUserCommand(UserId, editDto);
        await Mediator.Send(editUserCommand);

        return Ok();
    }

    [HttpPut]
    [Route("{userId:guid}/role")]
    public async Task<IActionResult> EditUserRole(Guid userId, [FromQuery] [Required] UserRole userRole)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("consideration")]
    public async Task<ActionResult<RegistrationRequestPagedListDto>> GetRegistrationRequestList(
        [FromQuery] RegistrationRequestSearchParameters parameters)
    {
        throw new NotImplementedException();
    }
}