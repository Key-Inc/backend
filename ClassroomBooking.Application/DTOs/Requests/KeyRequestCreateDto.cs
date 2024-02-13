﻿using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class KeyRequestCreateDto
{
    [Required]
    public required DateTime StartDate { get; set; }
    
    [Required]
    public required DateTime EndDate { get; set; }
    
    [Required]
    public required bool IsRecurring { get; set; }
    
    [Required]
    public required Guid UserId { get; set; }
    
    [Required]
    public required Guid KeyId { get; set; }
}