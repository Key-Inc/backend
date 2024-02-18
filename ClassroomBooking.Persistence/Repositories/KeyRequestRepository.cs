using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class KeyRequestRepository: BaseRepository<KeyRequest>, IKeyRequestRepository
{
    public KeyRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}
    
    public async Task<bool> IsDateRangeValidAsync(DateTime start, DateTime end, Guid id)
    {
        return await Entities
            .AllAsync(k => k.Status != RequestStatus.Accepted || k.ClassroomId != id ||
                           (k.IsRecurring != true && (k.EndDate < start || end < k.StartDate)) ||
                           (k.IsRecurring == true && k.StartDate.DayOfWeek == start.DayOfWeek &&
                            (k.EndDate.TimeOfDay < start.TimeOfDay || end.TimeOfDay < k.StartDate.TimeOfDay)));
    }

    public async Task<IEnumerable<KeyRequest>> GetByUserIdAsync(Guid userId)
    {
        return await Entities.Where(k => k.UserId == userId).ToListAsync();
    }
}