﻿using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Application.Common.Mappings;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public class UserDto : IMapFrom<User>
{
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    [MinLength(1)]
    public required string FullName { get; set; }
    
    public DateOnly? BirthDate { get; set; }
    
    [Required]
    public Gender Gender { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    [Required]
    [MinLength(1)]
    [EmailAddress]
    public required string Email { get; set; }
}