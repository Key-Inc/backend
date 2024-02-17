using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class UserPagedListDto
{
    [Required]
    public required IEnumerable<UserFullDto> Users { get; set; }
    
    [Required]
    public required PageInfoDto Pagination { get; set; }
}