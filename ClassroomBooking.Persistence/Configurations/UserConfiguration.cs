using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomBooking.Persistence.Configurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData(
            CreateUser(UserRole.Admin),
            CreateUser(UserRole.Dean),
            CreateUser(UserRole.Teacher),
            CreateUser(UserRole.Student));
    }

    private static User CreateUser(UserRole role)
    {
        var name = role.ToString().ToLower();

        return new User
        {
            Id = Guid.NewGuid(),
            FullName = name,
            Gender = Gender.Male,
            Email = $"{name}@gmail.com",
            Password = BCrypt.Net.BCrypt.HashPassword(name),
            UserRole = role
        };
    }
}