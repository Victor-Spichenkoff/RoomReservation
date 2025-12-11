    using EventPilot.Domain.Entities;
    using EventPilot.Domain.ValueObjects;
    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventPilot.Infrastructure.Config;

public class RegistrationConfiguration: IEntityTypeConfiguration<Registration>
{
    public void Configure(EntityTypeBuilder<Registration> builder)
    {
        var codeConverter = new ValueConverter<Code, string>(
            toDb => toDb.Value,
            fromDb => Code.Create(fromDb)
        );
        
        builder
            .Property(r => r.Code)
            .HasConversion(codeConverter)
            .HasMaxLength(6); // XX-123

        builder
            .HasOne(r => r.Event)
            .WithMany(e => e.Registrations)
            .HasForeignKey(r => r.EventId);
        
        builder
            .HasOne(r => r.User)
            .WithMany(u => u.Registrations)
            .HasForeignKey(r => r.UserId);
    }
}