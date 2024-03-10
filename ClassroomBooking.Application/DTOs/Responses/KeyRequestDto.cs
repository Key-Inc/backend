using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.Common.Mappings;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public class KeyRequestDto: IMapFrom<KeyRequest>
{
    [Required]
    public required Guid Id { get; set; }
    
    [Required]
    public required RequestStatus Status { get; set; }
    
    [Required]
    public required DateTime StartDate { get; set; }
    
    [Required]
    public required DateTime EndDate { get; set; }
    
    [Required]
    public ClassroomDto? Classroom { get; set; }
    
    public DateOnly? EndDateOfRecurrence { get; set; }
}