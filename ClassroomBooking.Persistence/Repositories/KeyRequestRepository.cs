using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class KeyRequestRepository: BaseRepository<KeyRequest>, IKeyRequestRepository
{
    public KeyRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}
    
    public async Task<bool> IsDateRangeValidAsync(DateTime start, DateTime end, bool isRecurring, Guid classroomId)
    {
        return await Entities
            .AllAsync(k => k.Status != RequestStatus.Accepted || k.ClassroomId != classroomId ||
                            (k.IsRecurring != true && isRecurring != true && (k.EndDate < start || end < k.StartDate)) ||
                            ((k.IsRecurring == true || isRecurring == true) && (k.StartDate.DayOfWeek != start.DayOfWeek ||
                                k.EndDate.TimeOfDay < start.TimeOfDay || end.TimeOfDay < k.StartDate.TimeOfDay)));
    }

    public async Task<IEnumerable<KeyRequest>> GetByUserIdAsync(Guid userId)
    {
        return await Entities.Where(k => k.UserId == userId).ToListAsync();
    }

    public async Task<IEnumerable<KeyRequest>> GetOverlapping(KeyRequest request)
    {
        var start = request.StartDate;
        var end = request.EndDate;
        return await Entities
            .Where(k => !(k.Id == request.Id || k.Status != RequestStatus.Accepted || k.ClassroomId != request.ClassroomId ||
                           (k.IsRecurring != true && request.IsRecurring != true && (k.EndDate < start || end < k.StartDate)) ||
                           ((k.IsRecurring == true || request.IsRecurring == true) && (k.StartDate.DayOfWeek != start.DayOfWeek ||
                            k.EndDate.TimeOfDay < start.TimeOfDay || end.TimeOfDay < k.StartDate.TimeOfDay))))
            .Include(k => k.User)
            .ToListAsync();
    }

    public async Task<bool> IsDateRangeValidForRequest(KeyRequest request)
    {
        var start = request.StartDate;
        var end = request.EndDate;
        return await Entities
            .AllAsync(k => k.Id == request.Id || k.Status != RequestStatus.Accepted || k.ClassroomId != request.ClassroomId ||
                            (k.IsRecurring != true && request.IsRecurring != true && (k.EndDate < start || end < k.StartDate)) ||
                            ((k.IsRecurring == true || request.IsRecurring == true) && (k.StartDate.DayOfWeek != start.DayOfWeek ||
                                k.EndDate.TimeOfDay < start.TimeOfDay || end.TimeOfDay < k.StartDate.TimeOfDay)));
    }
}