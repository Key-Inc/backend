using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class ClassroomPagedListDto
{
    [Required]
    public required IEnumerable<ClassroomDto> Classrooms { get; set; }
    
    [Required]
    public required PageInfoDto Pagination { get; set; }
}