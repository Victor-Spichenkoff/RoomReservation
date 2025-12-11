using EventPilot.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventPilot.Infrastructure.Context;

public class AppContext: DbContext
{
    public AppContext(DbContextOptions<AppContext> options) : base(options) { }

    public DbSet<Certificate> Certificates { get; set;}
    public DbSet<CheckIn> CheckIns { get; set;}
    public DbSet<Event> Events { get; set;}
    public DbSet<Registration> Registrations { get; set;}
    public DbSet<Session> Sessions { get; set;}
    // public DbSet<User> Users { get; set;}
    // public DbSet<User> Users { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // settings here
    }
}