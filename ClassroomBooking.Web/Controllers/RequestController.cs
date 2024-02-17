using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBooking.Web.Controllers;

public sealed class RequestController : BaseController
{
    [HttpGet]
    [Route("schedule")]
    public async Task<ActionResult<IEnumerable<ScheduleDto>>> GetSchedule(
        [FromQuery] ScheduleSearchParameters searchParameters)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("my")]
    public async Task<ActionResult<IEnumerable<KeyRequestDto>>> GetMyRequests()
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public async Task<ActionResult<KeyRequestPagedListDto>> GetKeyRequestList(
        [FromQuery] KeyRequestSearchParameters parameters)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateKeyRequest(KeyRequestCreateDto requestCreateDto)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route(("{requestId:guid}/key/{keyId:guid}/approve"))]
    public async Task<IActionResult> AcceptRequest(Guid requestId, Guid keyId)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{id:guid}/reject")]
    public async Task<IActionResult> RejectRequest(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    [Route("{id:guid}/delete")]
    public async Task<IActionResult> DeleteRequest(Guid id)
    {
        throw new NotImplementedException();
    }
}