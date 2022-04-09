﻿// <auto-generated />
using System;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FuelStation.EF.Migrations
{
    [DbContext(typeof(FuelStationContext))]
    partial class FuelStationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FuelStation.Model.Entities.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EmployeeType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("SalaryPerMonth")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.Item", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.Transaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.TransactionLine", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DiscountPercentage")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid>("ItemID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("NetValue")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid>("TransactionID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ItemID");

                    b.HasIndex("TransactionID");

                    b.ToTable("TransactionLines");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.Transaction", b =>
                {
                    b.HasOne("FuelStation.Model.Entities.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FuelStation.Model.Entities.Employee", "Employee")
                        .WithMany("Transactions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.TransactionLine", b =>
                {
                    b.HasOne("FuelStation.Model.Entities.Item", "Item")
                        .WithMany("TransactionLines")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FuelStation.Model.Entities.Transaction", "Transaction")
                        .WithMany("TransactionLines")
                        .HasForeignKey("TransactionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.Customer", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.Employee", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.Item", b =>
                {
                    b.Navigation("TransactionLines");
                });

            modelBuilder.Entity("FuelStation.Model.Entities.Transaction", b =>
                {
                    b.Navigation("TransactionLines");
                });
#pragma warning restore 612, 618
        }
    }
}
