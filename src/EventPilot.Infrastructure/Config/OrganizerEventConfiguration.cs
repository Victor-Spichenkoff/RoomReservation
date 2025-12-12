using EventPilot.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPilot.Infrastructure.Config;

public class OrganizerEventConfiguration: IEntityTypeConfiguration<OrganizerEvent>
{
    public void Configure(EntityTypeBuilder<OrganizerEvent> builder)
    {
        builder
            .HasKey(oe => new { oe.EventId, oe.UserId });

        builder
            .HasOne(oe => oe.Event)
            .WithMany(e => e.OrganizerEvents)
            .HasForeignKey(oe => oe.EventId);
        
        builder
            .HasOne(oe => oe.User)
            .WithMany(u => u.OrganizerEvents)
            .HasForeignKey(oe => oe.UserId);
    }
}