using ClassroomBooking.Domain.Entities.Enums;
using Microsoft.AspNetCore.Authorization;

namespace ClassroomBooking.Infrastructure.Models;

public static class Policy
{
    public const string Admin = "RequireAdminRole";
    public const string Dean = "RequireDeanRole";
    public const string Teacher = "RequireTeacherRole";
    public const string Student = "RequireStudentRole";
    
    internal static void Configure(AuthorizationPolicyBuilder builder, UserRole role)
    {
        builder.RequireRole(role.ToString());
    }
}