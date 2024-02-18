using System.ComponentModel.DataAnnotations;
using AutoMapper;
using ClassroomBooking.Application.Common.Mappings;
using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.DTOs.Responses;

public class KeyDto: IMapFrom<Key>
{
    [Required]
    public required Guid Id { get; set; }
    
    [Required]
    public required Guid ClassroomId { get; set; }
}