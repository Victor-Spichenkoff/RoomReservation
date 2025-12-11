using EventPilot.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPilot.Infrastructure.Config;

public class OrganizerEventConfiguration: IEntityTypeConfiguration<OrganizerEvent>
{
    public void Configure(EntityTypeBuilder<OrganizerEvent> builder)
    {
        
    }
}