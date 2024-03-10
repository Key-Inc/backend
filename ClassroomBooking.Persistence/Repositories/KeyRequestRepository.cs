using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class KeyRequestRepository: BaseRepository<KeyRequest>, IKeyRequestRepository
{
    public KeyRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}
    
    public async Task<bool> IsDateRangeValidAsync(DateTime start, DateTime end, Guid classroomId)
    {
        return await Entities
            .AllAsync(k => k.Status != RequestStatus.Accepted
                           || k.ClassroomId != classroomId || k.EndDate <= start || end <= k.StartDate);
    }

    public async Task<IEnumerable<KeyRequest>> GetByUserIdAsync(Guid userId)
    {
        return await Entities
            .Where(k => k.UserId == userId)
            .Include(k => k.Classroom)
            .ToListAsync();
    }

    public async Task<IEnumerable<KeyRequest>> GetOverlappingAsync(KeyRequest request)
    {
        var start = request.StartDate;
        var end = request.EndDate;
        DateTime? endOfRecurrence = request.EndDateOfRecurrence == null ? null : DateTime.SpecifyKind(request.EndDateOfRecurrence.Value.ToDateTime(TimeOnly.MaxValue), DateTimeKind.Utc);
        return await Entities
            .Where(k => !(k.Id == request.Id || k.Status != RequestStatus.Accepted || k.ClassroomId != request.ClassroomId ||
                          (endOfRecurrence == null && (k.EndDate <= start || end <= k.StartDate)) || 
                          (endOfRecurrence != null && 
                           (start >= k.EndDate || k.StartDate >= endOfRecurrence || 
                            k.StartDate.DayOfWeek != start.DayOfWeek ||  
                            k.EndDate.TimeOfDay <= start.TimeOfDay ||
                            end.TimeOfDay <= k.StartDate.TimeOfDay))))
            .Include(k => k.User)
            .Include(k => k.Classroom)
            .ToListAsync();
    }

    public async Task<bool> IsDateRangeValidForRequestAsync(KeyRequest request)
    {
        var start = request.StartDate;
        var end = request.EndDate;
        DateTime? endOfRecurrence = request.EndDateOfRecurrence == null ? null : DateTime.SpecifyKind(request.EndDateOfRecurrence.Value.ToDateTime(TimeOnly.MaxValue), DateTimeKind.Utc);
        return await Entities
            .AllAsync(k => k.Id == request.Id || k.Status != RequestStatus.Accepted || k.ClassroomId != request.ClassroomId ||
                            (endOfRecurrence == null && (k.EndDate <= start || end <= k.StartDate)) ||
                            (endOfRecurrence != null && (start >= k.EndDate || k.StartDate >= endOfRecurrence ||
                             k.StartDate.DayOfWeek != start.DayOfWeek ||  k.EndDate.TimeOfDay <= start.TimeOfDay || end.TimeOfDay <= k.StartDate.TimeOfDay)));
    }

    public async Task<List<KeyRequest>> GetScheduleAsync(DateTime date, Guid classroomId, UserRole role)
    {
        if (role == UserRole.Student) {
            return await Entities
                .Where(k => k.Status == RequestStatus.Accepted
                            && k.StartDate.Year == date.Year
                            && k.StartDate.Month == date.Month
                            && k.StartDate.Day == date.Day
                            && k.ClassroomId == classroomId)
                .OrderBy(k => k.StartDate)
                .ToListAsync();
        }
        return await Entities
            .Where(k => k.Status == RequestStatus.Accepted
                        && k.StartDate.Year == date.Year
                        && k.StartDate.Month == date.Month
                        && k.StartDate.Day == date.Day
                        && k.ClassroomId == classroomId && k.User != null && k.User.UserRole != UserRole.Student)
            .OrderBy(k => k.StartDate)
            .ToListAsync();
    }

    public async Task RejectRequestsAsync(IEnumerable<KeyRequest> requests)
    {
        foreach (var request in requests)
        {
            request.Status = RequestStatus.Rejected;
        }
        await SaveChangeAsync();
    }
}