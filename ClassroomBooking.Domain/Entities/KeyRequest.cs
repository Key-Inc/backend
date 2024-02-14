﻿using ClassroomBooking.Domain.Entities.Base;
using ClassroomBooking.Domain.Enums;

namespace ClassroomBooking.Domain.Entities;

public sealed class KeyRequest: BaseEntity
{
    public required RequestStatus Status { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required bool IsRecurring { get; set; }
    
    public required Guid UserId { get; set; }
    public required Guid KeyId { get; set; }
    
    public User? User { get; set; }
    public Key? Key { get; set; }
}