using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class RegistrationRequestRepository : BaseRepository<RegistrationRequest>, IRegistrationRequestRepository
{
    public RegistrationRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}

    public async Task<RegistrationRequest?> GetByUserIdAsync(Guid userId)
    {
        return await Entities.FirstOrDefaultAsync(request => request.UserId == userId);
    }

    public async Task<RegistrationRequest?> GetByUserIdIncludingUserAsync(Guid userId)
    {
        return await Entities
            .Include(request => request.User)
            .FirstOrDefaultAsync(request => request.UserId == userId);
    }
}