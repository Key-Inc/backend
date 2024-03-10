using System.ComponentModel.DataAnnotations;
using AutoMapper;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class KeyFullDto : KeyDto
{
    [Required]
    public required KeyStatus KeyStatus { get; set; }
    
    public required UserLiteDto? User { get; set; }
}