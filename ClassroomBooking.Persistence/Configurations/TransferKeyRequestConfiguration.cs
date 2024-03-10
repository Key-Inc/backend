using ClassroomBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomBooking.Persistence.Configurations;

public sealed class TransferKeyRequestConfiguration : IEntityTypeConfiguration<TransferKeyRequest>
{
    public void Configure(EntityTypeBuilder<TransferKeyRequest> builder)
    {
        builder
            .HasOne(request => request.Applicant)
            .WithMany(user => user.MyTransferKeyRequests)
            .HasForeignKey(request => request.ApplicantId);
        
        builder
            .HasOne(request => request.Recipient)
            .WithMany(user => user.TransferKeyRequests)
            .HasForeignKey(request => request.RecipientId);
    }
}