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
        return await Entities.Where(k => k.UserId == userId).ToListAsync();
    }

    public async Task<IEnumerable<KeyRequest>> GetOverlapping(KeyRequest request)
    {
        var start = request.StartDate;
        var end = request.EndDate;
        return await Entities
            .Where(k => !(k.Id == request.Id || k.Status != RequestStatus.Accepted || k.ClassroomId != request.ClassroomId ||
                           k.EndDate <= start || end <= k.StartDate))
            .Include(k => k.User)
            .ToListAsync();
    }

    public async Task<bool> IsDateRangeValidForRequest(KeyRequest request)
    {
        var start = request.StartDate;
        var end = request.EndDate;
        return await Entities
            .AllAsync(k => k.Id == request.Id || k.Status != RequestStatus.Accepted || k.ClassroomId != request.ClassroomId ||
                            k.EndDate <= start || end <= k.StartDate);
    }

    public async Task<List<KeyRequest>> GetSchedule(DateTime date, Guid classroomId, UserRole role)
    {
        if (role == UserRole.Student){
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
}