using ClassroomBooking.Domain.Entities;
using MediatR.NotificationPublishers;

namespace ClassroomBooking.Application.Common.Interfaces.Repositories;

public interface IKeyRequestRepository : IBaseRepository<KeyRequest>
{
    Task<bool> IsDateRangeValidAsync(DateTime start, DateTime end, bool isRecurring, Guid classroomId);

    Task<IEnumerable<KeyRequest>> GetByUserIdAsync(Guid userId);

    Task<IEnumerable<KeyRequest>> GetOverlapping(KeyRequest request);

    Task<bool> IsDateRangeValidForRequest(KeyRequest request);
}