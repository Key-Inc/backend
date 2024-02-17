using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class KeyFullDto : KeyDto
{
    [Required]
    public required KeyStatus KeyStatus { get; set; }
    
    public Guid? UserId { get; set; }
}