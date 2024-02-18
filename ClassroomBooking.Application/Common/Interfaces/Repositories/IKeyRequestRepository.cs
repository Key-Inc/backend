using ClassroomBooking.Domain.Entities;
using MediatR.NotificationPublishers;

namespace ClassroomBooking.Application.Common.Interfaces.Repositories;

public interface IKeyRequestRepository : IBaseRepository<KeyRequest>
{
    Task<bool> IsDateRangeValidAsync(DateTime start, DateTime end, Guid classroomId);

    Task<IEnumerable<KeyRequest>> GetByUserIdAsync(Guid userId);

    Task<bool> IsDateRangeValidForRequest(KeyRequest request);
}