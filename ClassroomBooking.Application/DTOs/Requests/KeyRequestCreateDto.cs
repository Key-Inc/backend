﻿using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.Common.ValidationAttributes;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class KeyRequestCreateDto
{
    [Required]
    public required DateTime StartDate { get; set; }
    
    [Required]
    public required DateTime EndDate { get; set; }
    
    public DateOnly? EndDateOfRecurrence { get; set; }
    
    [Required]
    public required Guid ClassroomId { get; set; }
}