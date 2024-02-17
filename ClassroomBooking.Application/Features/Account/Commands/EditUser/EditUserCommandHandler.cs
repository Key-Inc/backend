using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.EditUser;

public sealed class EditUserCommandHandler : IRequestHandler<EditUserCommand>
{
    private readonly IUserRepository _userRepository;

    public EditUserCommandHandler(IUserRepository userRepository) => _userRepository = userRepository;
    
    public async Task Handle(EditUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId);
        if (user == null) throw new NotFoundException(nameof(User), request.UserId);
        
        user.BirthDate = request.UserEdit.BirthDate;
        user.PhoneNumber = request.UserEdit.PhoneNumber;
        if (request.UserEdit.Email != null) user.Email = request.UserEdit.Email;

        await _userRepository.UpdateAsync(user);
    }
}