using System.Security.Claims;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers.Base;

[ApiController]
[EnableCors]
[Route("api/[controller]")]
public abstract class BaseController : ControllerBase
{
    protected readonly IMediator Mediator;

    protected BaseController(IMediator mediator) =>  Mediator = mediator;

    internal Guid UserId
    {
        get
        {
            var value = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return User.Identity?.IsAuthenticated == null || value == null
                ? Guid.Empty
                : Guid.Parse(value);
        }
    }
}