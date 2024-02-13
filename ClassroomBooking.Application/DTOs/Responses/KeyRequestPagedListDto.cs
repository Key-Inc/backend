using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class KeyRequestPagedListDto
{
    [Required]
    public required IEnumerable<KeyRequestDto> Keys { get; set; }
    
    [Required]
    public required PageInfoDto Pagination { get; set; } 
}