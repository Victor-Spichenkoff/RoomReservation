    using EventPilot.Domain.Entities;
    using EventPilot.Domain.ValueObjects;
    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventPilot.Infrastructure.Config;

public class EventRegistrationConfiguration: IEntityTypeConfiguration<EventRegistration>
{
    public void Configure(EntityTypeBuilder<EventRegistration> builder)
    {
        builder
            .HasIndex(r => new { r.EventId, r.UserId })
            .IsUnique();

        builder
            .HasIndex(r => r.Code)
            .IsUnique();
            
        var codeConverter = new ValueConverter<Code, string>(
            toDb => toDb.Value,
            fromDb => Code.Create(fromDb)
        );
        
        builder
            .Property(r => r.Code)
            .HasConversion(codeConverter)
            .HasMaxLength(6); // XX-123
        
        builder
            .HasIndex(r => r.Code)
            .IsUnique();
        

        builder
            .HasOne(r => r.Event)
            .WithMany(e => e.EventRegistrations)
            .HasForeignKey(r => r.EventId);
        
        builder
            .HasOne(r => r.User)
            .WithMany(u => u.EventRegistrations)
            .HasForeignKey(r => r.UserId);
    }
}