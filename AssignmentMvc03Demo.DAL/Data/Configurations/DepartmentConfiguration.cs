using AssignmentMvc03Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMvc03Demo.DAL.Data.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)

        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);

            builder.Property(D => D.Code).HasColumnType("varchar(20)").IsRequired();

            builder.Property(D => D.Name).HasColumnType("varchar(50)").IsRequired();

            builder.Property(D => D.CreationDate).HasComputedColumnSql("CAST((GETDATE())as date)");

            builder.Property(D => D.CreatedOn).HasDefaultValue("GETDATE()");


            builder.Property(D => D.CreatedBy).HasDefaultValue("");


            builder.Property(D => D.LastModifiedOn).HasComputedColumnSql("GETDATE()");


            builder.Property(D => D.LastModifiedBy).HasComputedColumnSql("GETDATE()");




        }
    }
}
