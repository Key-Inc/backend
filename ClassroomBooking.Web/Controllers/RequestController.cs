using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class RequestController: BaseController
{
    [HttpGet]
    [Route("my")]
    public async Task<ActionResult<IEnumerable<KeyRequestDto>>> GetMyRequests()
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public async Task<ActionResult<KeyRequestPagedListDto>> GetKeyRequestList([FromQuery] KeyRequestSearchParameters parameters)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateKeyRequest(KeyRequestCreateDto requestCreateDto)
    {
        throw new NotImplementedException();
    }
    
    [HttpPut]
    [Route(("{id:guid}/accept"))]
    public async Task<IActionResult> AcceptRequest(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpPut]
    [Route("{id}/reject")]
    public async Task<IActionResult> RejectRequest(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpDelete]
    [Route("{id}/delete")]
    public async Task<IActionResult> DeleteRequest(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpPut]
    [Route("{id}/transfer")]
    public async Task<IActionResult> TransferRequest(Guid id)
    {
        throw new NotImplementedException();
    }    
}