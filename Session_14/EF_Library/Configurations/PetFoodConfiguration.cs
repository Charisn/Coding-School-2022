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
    internal class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("PetFood");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID);
            builder.Property(x => x.Cost);
            builder.Property(x => x.Price);
            builder.Property(x => x.AnimalType);
            builder.HasIndex(x => x.AnimalType).HasName("PetAnimalType");
        }
    }
}
