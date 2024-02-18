using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.Common.Interfaces.Repositories;

public interface IKeyRepository: IBaseRepository<Key>
{
    Task<IEnumerable<Key>> GetKeyByStatus(KeyStatus? status);
}