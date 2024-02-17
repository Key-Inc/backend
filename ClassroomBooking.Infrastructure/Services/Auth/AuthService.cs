using ClassroomBooking.Application.Common.Interfaces.Repositories;

namespace ClassroomBooking.Infrastructure.Services.Auth;

internal sealed class AuthService
{
    private readonly JwtProvider _jwtProvider;
    private readonly IUserRepository _userRepository;

    public AuthService(JwtProvider jwtProvider, IUserRepository userRepository)
    {
        _jwtProvider = jwtProvider;
        _userRepository = userRepository;
    }
}