using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Persistence.Contexts;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class TransferKeyRequestRepository : BaseRepository<TransferKeyRequest>, ITransferKeyRequestRepository
{
    public TransferKeyRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}
}