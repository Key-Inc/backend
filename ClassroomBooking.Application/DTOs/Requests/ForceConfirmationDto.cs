
using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Requests;

public class ForceConfirmationDto
{
    [Required]
    public required bool ForceConfirmation { get; set; }
}