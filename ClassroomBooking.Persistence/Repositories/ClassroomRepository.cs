using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class ClassroomRepository: BaseRepository<Classroom>, IClassroomRepository
{
    public ClassroomRepository(ApplicationDbContext dbContext) : base(dbContext) { }
}