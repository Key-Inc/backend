using System.Security.Authentication;
using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.Common.Interfaces.Services;
using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Infrastructure.Services.Auth;

internal sealed class AuthService : IAuthService
{
    private readonly JwtProvider _jwtProvider;
    private readonly IUserRepository _userRepository;
    private readonly IRegistrationRequestRepository _registrationRequestRepository;

    public AuthService(
        JwtProvider jwtProvider,
        IUserRepository userRepository, 
        IRegistrationRequestRepository registrationRequestRepository)
    {
        _jwtProvider = jwtProvider;
        _userRepository = userRepository;
        _registrationRequestRepository = registrationRequestRepository;
    }

    public async Task<TokenResponseDto> LogIn(LoginCredentialsDto credentials)
    {
        var user = await _userRepository.Entities.FirstOrDefaultAsync(existing => existing.Email == credentials.Email);
        if (user == null) throw new InvalidCredentialException($"No accounts registered with {credentials.Email}.");

        var verified = BCrypt.Net.BCrypt.Verify(credentials.Password, user.Password);
        if (verified == false) throw new InvalidCredentialException($"Invalid credentials for {credentials.Email}.");

        return GetTokenResponse(user);
    }
    
    public async Task<TokenResponseDto> Register(User user)
    {
        var userExists = await _userRepository.Entities.AnyAsync(existing => existing.Email == user.Email);
        if (userExists) throw new BadRequestException($"User with {user.Email} already exists");

        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
        user.Password = hashedPassword;
        
        await _userRepository.AddAsync(user);
        await AddRegistrationRequest(user.Id);

        return GetTokenResponse(user);
    }

    private TokenResponseDto GetTokenResponse(User user) =>
        new TokenResponseDto { Token = _jwtProvider.GenerateToken(user) };

    private async Task AddRegistrationRequest(Guid userId)
    {
        var registrationRequest = new RegistrationRequest
        {
            UserId = userId,
            Status = RequestStatus.UnderConsideration
        };

        await _registrationRequestRepository.AddAsync(registrationRequest);
    }
}