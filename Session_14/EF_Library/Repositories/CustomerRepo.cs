using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_Library.Repositories;

internal class CustomerRepo : IEntityRepo<Customer>
{
    public async Task Create(Customer entity)
    {
        using var context = new PetShopLibContext();
        context.Customers.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        using var context = new PetShopLibContext();
        var foundCustomer = context.Customers.SingleOrDefault(x => x.ID.Equals(id));
        if (foundCustomer is null)
            return;

        context.Customers.Remove(foundCustomer);
        await context.SaveChangesAsync();
    }

    public List<Customer> GetAll()
    {
        using var context = new PetShopLibContext();
        return context.Customers.ToList();
    }

    public Customer? GetById(Guid id)
    {
        using var context = new PetShopLibContext();
        return context.Customers.Where(x => x.ID.Equals(id)).SingleOrDefault();
    }

    public async Task Update(Guid id, Customer entity)
    {
        using var context = new PetShopLibContext();
        var foundCustomer = context.Customers.Include(x => x.TIN).Include(x => x.Phone).Include(x => x.Name).Include(x => x.SurName).SingleOrDefault(x => x.ID.Equals(id));
        if (foundCustomer is null)
            return;
        foundCustomer.SurName = entity.SurName;
        foundCustomer.Phone = entity.Phone;
        foundCustomer.Name = entity.Name;
        foundCustomer.TIN = entity.TIN;
        await context.SaveChangesAsync();
    }
}
