using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLib.Impl;


namespace EF_Library.Repositories;

internal class MockEmployeeRepo
{
    private List<Employee> _employee = new List<Employee>() { new Employee(), new Employee() };

    public Task Create(Employee entity)
    {
        _employee.Add(entity);
        return Task.CompletedTask;
    }

    public Task Delete(int id)
    {
        var foundEmployee = _employee.SingleOrDefault(x => x.ID.Equals(id));
        if (foundEmployee is null)
            return Task.CompletedTask;
        _employee.Remove(foundEmployee);
        return Task.CompletedTask;
    }

    public List<Employee> GetAll()
    {
        return _employee;
    }

    public Employee? GetById(int id)
    {
        return _employee.SingleOrDefault(x => x.ID.Equals(id));
    }

    public Task Update(int id, Employee entity)
    {
        var foundEmployee = _employee.SingleOrDefault(x => x.ID.Equals(id));
        if (foundEmployee is null)
            return Task.CompletedTask;
        foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
        foundEmployee.EmployeeType = entity.EmployeeType;
        foundEmployee.Name = entity.Name;
        foundEmployee.SurName = entity.SurName;
        return Task.CompletedTask;
    }
}

