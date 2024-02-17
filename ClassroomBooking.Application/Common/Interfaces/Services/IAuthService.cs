using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;

namespace ClassroomBooking.Application.Common.Interfaces.Services;

public interface IAuthService
{
    Task<TokenResponseDto> LogIn(LoginCredentialsDto credentials);
}