using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.Login;

public sealed record LoginCommand(LoginCredentialsDto Credentials) : IRequest<TokenResponseDto>;