using ClassroomBooking.Application.Common.Exceptions;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Queries.GetRole;

public class GetRoleQueryHandler: IRequestHandler<GetRoleQuery, UserRole?>
{
    private readonly IUserRepository _userRepository;

    public GetRoleQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserRole?> Handle(GetRoleQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId);
        if (user == null) throw new UserNotFoundException(request.UserId);

        return user.UserRole;
    }
}