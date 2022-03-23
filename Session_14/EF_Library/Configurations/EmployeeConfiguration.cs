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
            builder.HasKey(Employee => Employee.ID);

            builder.Property(Employee => Employee.ID);
            builder.Property(Employee => Employee.Name).HasMaxLength(50);
            builder.Property(Employee => Employee.SurName).HasMaxLength(50);
            builder.Property(Employee => Employee.SalaryPerMonth);
            builder.Property(Employee => Employee.EmployeeType);
        }
    }
}
