using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class PagedListDto<T>
{
    [Required]
    public required IEnumerable<T> Items { get; set; }
    
    [Required]
    public required PageInfoDto Pagination { get; set; }
}