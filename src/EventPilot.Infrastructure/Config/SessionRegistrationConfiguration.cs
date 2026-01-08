using EventPilot.Domain.Entities;
using EventPilot.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPilot.Infrastructure.Config;

public class SessionRegistrationConfiguration: IEntityTypeConfiguration<SessionRegistration>
{
    public void Configure(EntityTypeBuilder<SessionRegistration> builder)
    {
        var validStatuses = string.Join(
            ",",
            Enum.GetValues<SessionRegistrationStatus>().Select(x => (int)x)
        );

        builder.ToTable(t =>
            t.HasCheckConstraint(
                "CK_SessionRegistration_Status",
                $"[Status] IN ({validStatuses})"
            )
        );

        builder.Property(sr => sr.Status)
            .HasConversion<int>()
            .IsRequired();
        
        builder
            .HasKey(sr => new { sr.SessionId, sr.EventRegistrationId });

        builder
            .HasOne(sr => sr.EventRegistration)
            .WithMany(er => er.SessionRegistrations)
            .HasForeignKey(sr => sr.EventRegistrationId);

        builder
            .HasOne(sr => sr.Session)
            .WithMany(s => s.SessionRegistrations)
            .HasForeignKey(sr => sr.SessionId);

        
        
        builder
            .Property(sr => sr.Status)
            .HasConversion<int>();
    }
}