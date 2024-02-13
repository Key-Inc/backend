using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class TokenResponseDto
{
    [Required]
    [MinLength(1)]
    public required string Token { get; set; }
}