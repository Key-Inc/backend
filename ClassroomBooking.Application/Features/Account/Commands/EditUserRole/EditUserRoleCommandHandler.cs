using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.EditUserRole;

public sealed class EditUserRoleCommandHandler : IRequestHandler<EditUserRoleCommand>
{
    private readonly IUserRepository _userRepository;

    public EditUserRoleCommandHandler(IUserRepository userRepository) => _userRepository = userRepository;
    
    public async Task Handle(EditUserRoleCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId);
        
        if (user == null) throw new NotFoundException(nameof(User), request.UserId);
        if (user.UserRole == null) throw new BadRequestException($"User ({request.UserId}) is not approved");

        user.UserRole = request.Role;
        await _userRepository.UpdateAsync(user);
    }
}