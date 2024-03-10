using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Repositories;

internal sealed class TransferKeyRequestRepository : BaseRepository<TransferKeyRequest>, ITransferKeyRequestRepository
{
    public TransferKeyRequestRepository(ApplicationDbContext dbContext) : base(dbContext) {}

    public async Task<TransferKeyRequest?> GetByRecipientIdAndKeyId(Guid recipientId, Guid keyId) =>
        await GetByRecipientIdAndKeyId(Entities, recipientId, keyId);

    public async Task<TransferKeyRequest?> GetByRecipientIdAndKeyIdIncludingAll(Guid recipientId, Guid keyId)
    {
        var entities = Entities
            .Include(request => request.Key)
            .Include(request => request.Recipient);

        return await GetByRecipientIdAndKeyId(entities, recipientId, keyId);
    }

    private async Task<TransferKeyRequest?> GetByRecipientIdAndKeyId(
        IQueryable<TransferKeyRequest> entities,
        Guid recipientId,
        Guid keyId)
    {
        return await entities.FirstOrDefaultAsync(request => request.RecipientId == recipientId 
                                                      && request.KeyId == keyId 
                                                      && request.Status == RequestStatus.UnderConsideration);
    }
}