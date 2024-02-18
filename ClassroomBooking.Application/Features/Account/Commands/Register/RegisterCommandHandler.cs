using ClassroomBooking.Application.Common.Interfaces.Services;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.Register;

public sealed class RegisterCommandHandler : IRequestHandler<RegisterCommand, TokenResponseDto>
{
    private readonly IAuthService _authService;

    public RegisterCommandHandler(IAuthService authService) => _authService = authService;
        
    public async Task<TokenResponseDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            FullName = request.UserRegister.FullName,
            BirthDate = request.UserRegister.BirthDate,
            Gender = request.UserRegister.Gender,
            Email = request.UserRegister.Email,
            Password = request.UserRegister.Password,
            PhoneNumber = request.UserRegister.PhoneNumber
        };

        return await _authService.Register(user);
    }
}