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
            builder.HasKey(PetFood => PetFood.ID);

            builder.Property(PetFood => PetFood.ID);
            builder.Property(PetFood => PetFood.Cost);
            builder.Property(PetFood => PetFood.Price);
            builder.Property(PetFood => PetFood.AnimalType);
            builder.HasIndex(PetFood => PetFood.AnimalType).HasName("PetAnimalType");
        }
    }
}
