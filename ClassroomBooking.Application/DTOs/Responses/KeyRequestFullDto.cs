using System.ComponentModel.DataAnnotations;
using AutoMapper;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class KeyRequestFullDto : KeyRequestDto
{
    [Required]
    public required UserLiteDto? User { get; set; }
}