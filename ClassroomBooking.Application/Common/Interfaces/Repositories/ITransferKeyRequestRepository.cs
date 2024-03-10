using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.Common.Interfaces.Repositories;

public interface ITransferKeyRequestRepository : IBaseRepository<TransferKeyRequest>
{
    Task<TransferKeyRequest?> GetByRecipientIdAndKeyId(Guid userId, Guid keyId);
    Task<TransferKeyRequest?> GetByRecipientIdAndKeyIdIncludingAll(Guid recipientId, Guid keyId);
}