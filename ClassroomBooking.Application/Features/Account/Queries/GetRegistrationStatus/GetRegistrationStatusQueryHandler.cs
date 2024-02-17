using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Account.Queries.GetRegistrationStatus;

public sealed class GetRegistrationStatusQueryHandler : IRequestHandler<GetRegistrationStatusQuery, RequestStatus>
{
    private readonly IRegistrationRequestRepository _registrationRequestRepository;

    public GetRegistrationStatusQueryHandler(IRegistrationRequestRepository registrationRequestRepository)
    {
        _registrationRequestRepository = registrationRequestRepository;
    }
    
    public async Task<RequestStatus> Handle(GetRegistrationStatusQuery request, CancellationToken cancellationToken)
    {
        var registrationRequest = await _registrationRequestRepository.GetByUserId(request.UserId);
        
        if (registrationRequest == null)
            throw new NotFoundException($"Registration request of user ({request.UserId}) was not wound");

        return registrationRequest.Status;
    }
}