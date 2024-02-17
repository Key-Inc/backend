using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class ClassroomDto
{
    [Required]
    public required Guid Id { get; set; }
    
    [Required]
    public required int Number { get; set; }
    
    [Required]
    public required int Building { get; set; }
    
    [Required]
    public required string Address { get; set; }
}