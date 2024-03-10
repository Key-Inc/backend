using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class TransferKeyRequestRepository : BaseRepository<TransferKeyRequest>, ITransferKeyRequestRepository
{
    public TransferKeyRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}
    
    public async Task<TransferKeyRequest?> GetByRecipientIdAndKeyId(Guid recipientId, Guid keyId) =>
        await Entities.FirstOrDefaultAsync(request => request.RecipientId == recipientId && request.KeyId == keyId);
}