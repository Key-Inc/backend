using ClassroomBooking.Domain.Entities.Base;

namespace ClassroomBooking.Domain.Entities;

public sealed class TransferKeyRequest : BaseEntity
{
    public Key? Key { get; set; }
    public required Guid KeyId { get; set; }
    
    public User? Recipient { get; set; }
    public required Guid RecipientId { get; set; }
}