using EventPilot.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPilot.Infrastructure.Config;

public class EventConfiguration: IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder
            .Property(e => e.Status)
            .HasConversion<int>();
    }
}