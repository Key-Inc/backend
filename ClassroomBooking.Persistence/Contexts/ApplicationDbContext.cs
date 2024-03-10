using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Persistence.Contexts;

public sealed class ApplicationDbContext : DbContext
{
    public DbSet<Key> Keys { get; init; }
    public DbSet<User> Users { get; init; }
    public DbSet<Classroom> Classrooms { get; init; }
    public DbSet<KeyRequest> KeyRequests { get; init; }
    public DbSet<TransferKeyRequest> TransferKeyRequests { get; init; }
    public DbSet<RegistrationRequest> RegistrationRequests { get; init; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new TransferKeyRequestConfiguration());
        
        var classrooms = GenerateClassrooms();
        builder.Entity<Classroom>().HasData(classrooms);
        builder.Entity<Key>().HasData(GenerateKeys(classrooms));
    }
    
    private static ICollection<Classroom> GenerateClassrooms()
    {
        var classrooms = new List<Classroom>();

        for (int building = 1; building <= 5; building++)
        {
            for (int number = 200; number <= 210; number++)
            {
                classrooms.Add(CreateClassroom(building, number));
            }
        }

        return classrooms;
    }

    private static IEnumerable<Key> GenerateKeys(IEnumerable<Classroom> classrooms)
    {
        var keys = new List<Key>();
        
        foreach (var classroom in classrooms)
        {
            keys.Add(CreateKey(classroom.Id));
        }

        return keys;
    }
    
    private static Key CreateKey(Guid classroomId) =>
        new()
        {
            Id = Guid.NewGuid(),
            KeyStatus = KeyStatus.InDeanOffice,
            ClassroomId = classroomId
        };
    
    private static Classroom CreateClassroom(int building, int number) =>
        new()
        {
            Id = Guid.NewGuid(),
            Number = number,
            Building = building
        };
}