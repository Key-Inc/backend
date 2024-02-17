using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

public abstract class BaseRepository<T>(DbContext dbContext) : IBaseRepository<T> where T : BaseEntity
{
    public IQueryable<T> Entities => dbContext.Set<T>();
    
    public async Task<T?> GetByIdAsync(Guid id) => await dbContext.Set<T>().FindAsync(id);
    
    public async Task UpdateAsync(T entity)
    {
        dbContext.Entry(entity).State = EntityState.Modified;
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        dbContext.Set<T>().Remove(entity);
        await dbContext.SaveChangesAsync();
    }
    
    public async Task AddAsync(T entity)
    {
        await dbContext.Set<T>().AddAsync(entity);
        await dbContext.SaveChangesAsync();
    }
}