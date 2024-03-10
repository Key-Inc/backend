using ClassroomBooking.Application.Common.Exceptions;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.ApproveRegistrationRequest;

public sealed class ApproveRegistrationRequestCommandHandler : IRequestHandler<ApproveRegistrationRequestCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IRegistrationRequestRepository _registrationRequestRepository;

    public ApproveRegistrationRequestCommandHandler(
        IUserRepository userRepository,
        IRegistrationRequestRepository registrationRequestRepository)
    {
        _userRepository = userRepository;
        _registrationRequestRepository = registrationRequestRepository;
    }
    
    public async Task Handle(ApproveRegistrationRequestCommand request, CancellationToken cancellationToken)
    {
        var user = await GetUser(request.UserId);
        if (user.UserRole < request.ApplicantRole) throw new RoleLessException();

        var registrationRequest = await GetRegistrationRequest(request.ApplicantId);
        if (registrationRequest.Status != RequestStatus.UnderConsideration) 
            throw new RegistrationRequestConsideredException(request.ApplicantId);

        registrationRequest.Status = RequestStatus.Accepted;
        if (registrationRequest.User != null) registrationRequest.User.UserRole = request.ApplicantRole;

        await _registrationRequestRepository.UpdateAsync(registrationRequest);
    }

    private async Task<User> GetUser(Guid userId)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        if (user == null) throw new UserNotFoundException(userId);

        return user;
    }

    private async Task<RegistrationRequest> GetRegistrationRequest(Guid applicantId)
    {
        var registrationRequest = await _registrationRequestRepository.GetByUserIdIncludingUserAsync(applicantId);
        if (registrationRequest == null) throw new RegistrationRequestNotFoundException(applicantId);

        return registrationRequest;
    }
}
