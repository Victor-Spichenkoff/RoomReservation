    using EventPilot.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPilot.Infrastructure.Config;

public class CheckInConfiguration: IEntityTypeConfiguration<CheckIn>
{
    public void Configure(EntityTypeBuilder<CheckIn> builder)
    {
        builder
            .HasKey(c => new { c.RegistrationId, c.SessionId });

        builder
            .HasOne(c => c.EventRegistration)
            .WithMany(r => r.CheckIns)
            .HasForeignKey(c => c.RegistrationId);

        builder
            .HasOne(c => c.Session)
            .WithMany(r => r.CheckIns)
            .HasForeignKey(c => c.SessionId);

        builder
            .Property(c => c.CheckInOrigin)
            .HasConversion<int>();
    }
}