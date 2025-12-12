using EventPilot.Domain.Entities;
using EventPilot.Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace EventPilot.Infrastructure.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Certificate> Certificates { get; set;}
    public DbSet<CheckIn> CheckIns { get; set;}
    public DbSet<Event> Events { get; set;}
    public DbSet<EventRegistration> EventRegistrations { get; set;}
    public DbSet<Session> Sessions { get; set;}
    public DbSet<OrganizerEvent> OrganizerEvents { get; set;}
    public DbSet<SessionRegistration> RegistrationSessions { get; set;}
    public DbSet<User> Users { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // settings here

        modelBuilder.ApplyConfiguration(new CertificateConfiguration());
        modelBuilder.ApplyConfiguration(new CheckInConfiguration());
        modelBuilder.ApplyConfiguration(new EventConfiguration());
        modelBuilder.ApplyConfiguration(new OrganizerEventConfiguration());
        modelBuilder.ApplyConfiguration(new EventRegistrationConfiguration());
        modelBuilder.ApplyConfiguration(new SessionRegistrationConfiguration());
        modelBuilder.ApplyConfiguration(new SessionConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}