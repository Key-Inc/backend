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
        if (registrationRequest.Status != RequestStatus.UnderConsideration)
            throw new BadRequestException($"Request of user ({request.ApplicantId}) has already been considered");

        registrationRequest.Status = RequestStatus.Rejected;
        await _registrationRequestRepository.UpdateAsync(registrationRequest);
    }
}