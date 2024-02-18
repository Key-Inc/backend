using ClassroomBooking.Domain.Entities;
using MediatR.NotificationPublishers;

namespace ClassroomBooking.Application.Common.Interfaces.Repositories;

public interface IKeyRequestRepository : IBaseRepository<KeyRequest>
{
    Task<bool> IsDateRangeValidAsync(DateTime start, DateTime end, Guid id);

    Task<IEnumerable<KeyRequest>> GetByUserIdAsync(Guid userId);
}