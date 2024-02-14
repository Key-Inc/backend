using ClassroomBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Key = Microsoft.EntityFrameworkCore.Metadata.Internal.Key;

namespace ClassroomBooking.Persistence.Contexts;

public sealed class ApplicationDbContext : DbContext
{
    public DbSet<Key> Keys { get; init; }
    public DbSet<User> Users { get; init; }
    public DbSet<KeyRequest> KeyRequests { get; init; }
    public DbSet<RegistrationRequest> RegistrationRequests { get; init; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
}