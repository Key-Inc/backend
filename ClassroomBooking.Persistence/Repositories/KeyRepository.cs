using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class KeyRepository: BaseRepository<Key>, IKeyRepository
{
    public KeyRepository(ApplicationDbContext dbContext) : base(dbContext) {}

    public async Task<IEnumerable<Key>> GetKeyByStatusAsync(KeyStatus? status)
    {
        return await Entities
            .Where(k => status == null || k.KeyStatus == status)
            .Include(k => k.User)
            .ToListAsync();
    }

    public async Task<IEnumerable<Key>> GetKeyByUserIdAsync(Guid userId)
    {
        return await Entities.Where(k => k.UserId == userId).ToListAsync();
    }
}