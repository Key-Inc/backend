﻿using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Domain.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class KeyDto
{
    [Required]
    public required KeyStatus KeyStatus { get; set; }
    
    [Required]
    [Range(0, int.MaxValue)]
    public required int ClassroomNumber { get; set; }
    
    public Guid? UserId { get; set; }
}