using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class TransferKeyRequest : BaseEntity
{
    public required RequestStatus Status { get; set; }
    
    public Key? Key { get; set; }
    public required Guid KeyId { get; set; }
    
    public User? Applicant { get; set; }
    public required Guid ApplicantId { get; set; }
    
    public User? Recipient { get; set; }
    public required Guid RecipientId { get; set; }
}