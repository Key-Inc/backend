using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.Common.Mappings;
using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class ClassroomDto: IMapFrom<Classroom>
{
    [Required]
    public required Guid Id { get; set; }
    
    [Required]
    public required int Number { get; set; }
    
    [Required]
    public required int Building { get; set; }
}