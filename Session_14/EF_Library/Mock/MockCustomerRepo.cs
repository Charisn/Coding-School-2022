using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLib.Impl;


namespace EF_Library.Repositories;

public class MockCustomerRepo : IEntityRepo<Customer>
{
    private List<Customer> _customer = new List<Customer>() { new Customer(), new Customer() };

    public Task Create(Customer entity)
    {
        _customer.Add(entity);
        return Task.CompletedTask;
    }

    public Task Delete(Guid id)
    {
        var foundEmployee = _customer.SingleOrDefault(x => x.ID.Equals(id));
        if (foundEmployee is null)
            return Task.CompletedTask;
        _customer.Remove(foundEmployee);
        return Task.CompletedTask;
    }

    public List<Customer> GetAll()
    {
        return _customer;
    }

    public Customer? GetById(Guid id)
    {
        return _customer.SingleOrDefault(x => x.ID.Equals(id));
    }

    public Task Update(Guid id, Customer entity)
    {
        var foundCustomer = _customer.SingleOrDefault(x => x.ID.Equals(id));
        if (foundCustomer is null)
            return Task.CompletedTask;
        foundCustomer.SurName = entity.SurName;
        foundCustomer.Phone = entity.Phone;
        foundCustomer.Name = entity.Name;
        foundCustomer.TIN = entity.TIN;
        return Task.CompletedTask;
    }
}
