using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.Common.Interfaces.Repositories;

public interface IRegistrationRequestRepository : IBaseRepository<RegistrationRequest>
{
    Task<RegistrationRequest?> GetByUserId(Guid userId);
}