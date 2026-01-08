using EventPilot.Domain.Entities;
using EventPilot.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventPilot.Infrastructure.Config;

public class UserConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        var validStatuses = string.Join(
            ",",
            Enum.GetValues<Roles>().Select(x => (int)x)
        );

        builder.ToTable(t =>
            t.HasCheckConstraint(
                "CK_User_Role",
                $"[Role] IN ({validStatuses})"
            )
        );
        
        builder
            .Property(p => p.Role)
            .HasConversion<int>();
        
        builder
            .HasIndex(p => p.Email)
            .IsUnique();
    }
}