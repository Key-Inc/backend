using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.Common.Interfaces.Services;

public interface IAuthService
{
    Task<TokenResponseDto> Register(User user);
    Task<TokenResponseDto> LogIn(LoginCredentialsDto credentials);
}