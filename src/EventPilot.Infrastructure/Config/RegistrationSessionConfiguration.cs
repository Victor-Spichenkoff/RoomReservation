using EventPilot.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPilot.Infrastructure.Config;

public class RegistrationSessionConfiguration: IEntityTypeConfiguration<RegistrationSession>
{
    public void Configure(EntityTypeBuilder<RegistrationSession> builder)
    {
        
    }
}