using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library.Configurations
{
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(Transaction => Transaction.ID);
            builder.Property(Transaction => Transaction.ID);

            builder.Property(Transaction => Transaction.PetFoodQty);
            builder.Property(Transaction => Transaction.PetFoodPrice);
            builder.Property(Transaction => Transaction.PetPrice);
            builder.Property(Transaction => Transaction.TotalPrice);
            builder.Property(Transaction => Transaction.CustomerID);
            builder.Property(Transaction => Transaction.EmployeeID);
            builder.Property(Transaction => Transaction.Date);
            builder.Property(Transaction => Transaction.PetFoodID);
            builder.Property(Transaction => Transaction.PetID);
        }
    }
}
