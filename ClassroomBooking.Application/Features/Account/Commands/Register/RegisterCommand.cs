using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.Register;

public sealed record RegisterCommand(UserRegisterDto UserRegister) : IRequest<TokenResponseDto>;