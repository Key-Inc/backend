using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.Common.Mappings;
using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class TransferKeyRequestDto : IMapFrom<TransferKeyRequest>
{
    [Required]
    public required Guid ApplicantId { get; set; }
    
    [Required]
    public required string ApplicantName { get; set; }

    [Required] public required Key Key { get; set; }
}