using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Persistence.Contexts;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class RegistrationRequestRepository : BaseRepository<RegistrationRequest>, IRegistrationRequestRepository
{
    public RegistrationRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}
}