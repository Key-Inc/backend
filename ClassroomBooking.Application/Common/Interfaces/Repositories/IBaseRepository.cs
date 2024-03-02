using ClassroomBooking.Domain.Entities.Base;

namespace ClassroomBooking.Application.Common.Interfaces.Repositories;

public interface IBaseRepository<T> where T : BaseEntity
{
    IQueryable<T> Entities { get; }
    Task AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task UpdateAsync(T entity);
    Task<T?> GetByIdAsync(Guid id);
    Task AddEntitiesAsync(IEnumerable<T> entities);
    Task SaveChangeAsync();
}