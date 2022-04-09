using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration;

internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(customer => customer.ID);

        builder.Property(customer => customer.Name).HasMaxLength(50);
        builder.Property(customer => customer.Surname).HasMaxLength(50);
        builder.Property(customer => customer.EmployeeType).HasMaxLength(50);
        builder.Property(customer => customer.SalaryPerMonth).HasColumnType("decimal(10,2)");
    }
}