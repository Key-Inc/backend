using System.ComponentModel.DataAnnotations;
using ClassroomBooking.Domain.Enums;

namespace ClassroomBooking.Application.DTOs.Requests;

public sealed class KeyEditDto
{
    public KeyStatus? KeyStatus { get; set; }
    
    public Guid? UserId { get; set; }
}