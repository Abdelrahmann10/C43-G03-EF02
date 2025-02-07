using EF2_FluentAPIs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
            //.HasKey("DepId")
            //.HasKey(nameof(Department.DepId))
                .HasKey(D => D.DepId);
            builder.Property(P => P.DepId).UseIdentityColumn(10, 10);
            builder
                .Property(P => P.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .IsRequired();
            builder
                .Property(P => P.CreationDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
