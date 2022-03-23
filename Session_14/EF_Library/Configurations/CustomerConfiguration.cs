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
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.SurName).HasMaxLength(50);
            builder.Property(x => x.Phone);
            builder.Property(x => x.TIN);
        }
    }
}
