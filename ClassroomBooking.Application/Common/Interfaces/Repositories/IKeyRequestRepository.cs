using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.Common.Interfaces.Repositories;

public interface IKeyRequestRepository : IBaseRepository<KeyRequest>
{
    Task<bool> IsDateRangeValid(DateTime start, DateTime end, Guid id);
}