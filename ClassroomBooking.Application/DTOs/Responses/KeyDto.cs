using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class KeyDto
{
    [Required]
    public required Guid Id { get; set; }
    
    [Required]
    [Range(0, int.MaxValue)]
    public required int ClassroomNumber { get; set; }
}