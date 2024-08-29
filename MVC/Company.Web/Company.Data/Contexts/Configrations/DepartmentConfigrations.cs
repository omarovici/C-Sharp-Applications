using Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Models.Contexts.Configrations;

public class DepartmentConfigrations : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Property(x => x.Id).UseIdentityColumn(10, 10);
        builder.HasIndex(x => x.Name).IsUnique();
    }
}