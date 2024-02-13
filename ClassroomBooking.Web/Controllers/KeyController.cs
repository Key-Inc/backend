using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Enums;
using ClassroomBooking.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class KeyController: BaseController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<KeyDto>>> GetKeys()
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{id:guid}/user/{userId:guid}/issued")]
    public async Task<IActionResult> IssuedKey(Guid id, Guid userId)
    {
        throw new NotImplementedException();
    }
    
    [HttpPut]
    [Route("{id:guid}/instock")]
    public async Task<IActionResult> InStockKey(Guid id)
    {
        throw new NotImplementedException();
    }
}