using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class KeyRequestFullDto : KeyRequestDto
{
    [Required]
    public required Guid UserId { get; set; }
}