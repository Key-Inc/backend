using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Persistence.Contexts;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class UserRepository(ApplicationDbContext dbContext) : BaseRepository<User>(dbContext), IUserRepository {}