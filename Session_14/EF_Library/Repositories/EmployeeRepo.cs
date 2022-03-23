using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;

namespace EF_Library.Repositories;

internal class EmployeeRepo
{
    public async Task Create(Employee entity)
    {
        using var context = new PetShopLibContext();
        context.Employees.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new PetShopLibContext();
        var foundEmployee = context.Employees.SingleOrDefault(x => x.ID.Equals(id));
        if (foundEmployee is null)
            return;

        context.Employees.Remove(foundEmployee);
        await context.SaveChangesAsync();
    }

    public List<Employee> GetAll()
    {
        using var context = new PetShopLibContext();
        return context.Employees.ToList();
    }

    public Employee? GetById(int id)
    {
        using var context = new PetShopLibContext();
        return context.Employees.Where(x => x.ID.Equals(id)).SingleOrDefault();
    }

    public async Task Update(int id, Employee entity)
    {
        using var context = new PetShopLibContext();
        var foundEmployee = context.Employees.Include(x => x.SalaryPerMonth).Include(x => x.EmployeeType).Include(x => x.SurName).Include(x => x.Name).SingleOrDefault(x => x.ID.Equals(id));
        if (foundEmployee is null)
            return;
        foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
        foundEmployee.EmployeeType = entity.EmployeeType;
        foundEmployee.Name = entity.Name;
        foundEmployee.SurName = entity.SurName;
        await context.SaveChangesAsync();
    }
}
