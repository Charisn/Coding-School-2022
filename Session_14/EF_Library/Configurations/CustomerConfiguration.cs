using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(Customer => Customer.ID);

            builder.Property(Customer => Customer.ID);
            builder.Property(Customer => Customer.Name).HasMaxLength(50);
            builder.Property(Customer => Customer.SurName).HasMaxLength(50);
            builder.Property(Customer => Customer.Phone);
            builder.Property(Customer => Customer.TIN);
        }
    }
}
