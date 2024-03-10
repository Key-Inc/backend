using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.CreateRequest;

public sealed record CreateRequestCommand(KeyRequestCreateDto RequestDto, Guid UserId): IRequest;
