using ClassroomBooking.Application.Common.Mappings;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;

namespace ClassroomBooking.Application.DTOs.Responses;

public class UserLiteDto: IMapFrom<User>
{
    public required string FullName { get; set; }
    public UserRole? UserRole { get; set; }
}