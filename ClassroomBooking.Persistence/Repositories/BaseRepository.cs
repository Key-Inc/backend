using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly DbContext _dbContext;

    protected BaseRepository(DbContext dbContext) => _dbContext = dbContext;

    public IQueryable<T> Entities => _dbContext.Set<T>();
    
    public async Task<T?> GetByIdAsync(Guid id) => await _dbContext.Set<T>().FindAsync(id);
    
    public async Task UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
}