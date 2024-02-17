using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

public sealed class UserRepository(DbContext dbContext) : BaseRepository<User>(dbContext), IUserRepository {}