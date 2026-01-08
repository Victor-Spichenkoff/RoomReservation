using EventPilot.Domain.Entities;
using EventPilot.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace EventPilot.Infrastructure.Config;

public class EventConfiguration: IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        var validStatuses = string.Join(
            ",",
            Enum.GetValues<EventStatus>().Select(x => (int)x)
        );

        builder.ToTable(t =>
            t.HasCheckConstraint(
                "CK_Event_Status",
                $"[Status] IN ({validStatuses})"
            )
        );
        
        builder
            .Property(e => e.Description)
            .HasMaxLength(250);
        
        builder
            .Property(e => e.Status)
            .HasConversion<int>();

        builder
            .Property(e => e.CreationDate)
            .HasDefaultValueSql("datetime('now')")
            .ValueGeneratedOnAdd();
    }
}