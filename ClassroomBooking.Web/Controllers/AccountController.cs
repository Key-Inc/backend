using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Enums;
using ClassroomBooking.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class AccountController: BaseController
{
    [HttpPost]
    [Route("register")]
    public async Task<ActionResult<TokenResponseDto>> Register(UserRegisterDto registerDto)
    {
        throw new NotImplementedException();
    }
    
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> LogIn(LoginCredentialsDto credentials)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("profile")]
    public async Task<ActionResult<UserDto>> GetProfile()
    {
        throw new NotImplementedException();
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
    public async Task<IActionResult> EditProfile(UserEditDto editDto)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{userId:guid}/role")]
    public async Task<IActionResult> EditUserRole(Guid userId, [FromQuery] [Required] UserRole userRole)
    {
        throw new NotImplementedException();
    }
    
    [HttpGet]
    [Route("consideration")]
    public async Task<ActionResult<RegistrationRequestPagedListDto>> GetRegistrationRequestList([FromQuery] RegistrationRequestSearchParameters parameters)
    {
        throw new NotImplementedException();
    }
}