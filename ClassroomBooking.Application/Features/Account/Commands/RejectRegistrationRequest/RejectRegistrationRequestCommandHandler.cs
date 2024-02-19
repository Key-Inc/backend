using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Commands.RejectRegistrationRequest;

public sealed class RejectRegistrationRequestCommandHandler : IRequestHandler<RejectRegistrationRequestCommand>
{
    private readonly IRegistrationRequestRepository _registrationRequestRepository;

    public RejectRegistrationRequestCommandHandler(IRegistrationRequestRepository registrationRequestRepository)
    {
        _registrationRequestRepository = registrationRequestRepository;
    }
    
    public async Task Handle(RejectRegistrationRequestCommand request, CancellationToken cancellationToken)
    {
        var registrationRequest = await _registrationRequestRepository.GetByUserIdAsync(request.ApplicantId);
        if (registrationRequest == null) throw new NotFoundException(nameof(User), request.ApplicantId);

        registrationRequest.Status = RequestStatus.Rejected;
        await _registrationRequestRepository.UpdateAsync(registrationRequest);
    }
}