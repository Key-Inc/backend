using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public class KeyDto
{
    [Required]
    public required Guid Id { get; set; }
    
    [Required]
    public required Guid ClassroomId { get; set; }
}