using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class RegistrationRequestRepository : BaseRepository<RegistrationRequest>, IRegistrationRequestRepository
{
    public RegistrationRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}

    public async Task<RegistrationRequest?> GetByUserId(Guid userId)
    {
        return await Entities.FirstOrDefaultAsync(request => request.UserId == userId);
    }
}