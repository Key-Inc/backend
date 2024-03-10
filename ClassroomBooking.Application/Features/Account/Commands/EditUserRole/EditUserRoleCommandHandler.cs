using ClassroomBooking.Application.Common.Exceptions;
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
        var user = await GetUser(request.UserId);
        if (user.UserRole < request.Role) throw new RoleLessException();
        
        var editableUser = await GetUser(request.EditableUserId);
        if (editableUser.UserRole == null) throw new BadRequestException($"User ({request.UserId}) is not approved");

        editableUser.UserRole = request.Role;
        await _userRepository.UpdateAsync(user);
    }

    private async Task<User> GetUser(Guid userId)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        if (user == null) throw new UserNotFoundException(userId);

        return user;
    }
}