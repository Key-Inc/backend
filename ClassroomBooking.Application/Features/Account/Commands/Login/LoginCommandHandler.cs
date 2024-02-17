using ClassroomBooking.Application.Common.Interfaces.Services;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.Login;

public sealed class LoginCommandHandler : IRequestHandler<LoginCommand, TokenResponseDto>
{
    private readonly IAuthService _authService;

    public LoginCommandHandler(IAuthService authService) => _authService = authService;

    public async Task<TokenResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        return await _authService.LogIn(request.Credentials);
    }
}