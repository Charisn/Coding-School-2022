using EF_Library.Configurations;
using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;


namespace EF_Library;

public class PetShopLibContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<Pet> Pets { get; set; }

    public DbSet<PetFood> PetFoods { get; set; }

    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbPetShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        optionsBuilder.UseSqlServer(connString);
    }
}
