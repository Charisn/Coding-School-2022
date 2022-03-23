using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.SurName).HasMaxLength(50);
            builder.Property(x => x.SalaryPerMonth);
            builder.Property(x => x.EmployeeType);
        }
    }
}
