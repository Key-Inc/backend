using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomBooking.Persistence.Configurations;

public sealed class UserConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData(new User
        {
            Id = Guid.NewGuid(),
            FullName = "admin",
            Gender = Gender.Male,
            Email = "admin@gmail.com",
            Password = BCrypt.Net.BCrypt.HashPassword("admin"),
            UserRole = UserRole.Admin
        });
    }
}