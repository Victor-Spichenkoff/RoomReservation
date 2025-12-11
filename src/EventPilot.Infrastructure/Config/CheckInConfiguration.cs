    using EventPilot.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPilot.Infrastructure.Config;

public class CheckInConfiguration: IEntityTypeConfiguration<CheckIn>
{
    public void Configure(EntityTypeBuilder<CheckIn> builder)
    {
        
    }
}