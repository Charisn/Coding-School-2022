using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly IEntityRepo<Customer> _customerRepo;

    public CustomerController(IEntityRepo<Customer> customerRepo)
    {
        _customerRepo = customerRepo;
    }

    [HttpGet]
    public async Task<IEnumerable<CustomerViewModel>> Get()
    {
        var result = await _customerRepo.GetAllAsync();

        var customer = result.Select(x => new CustomerViewModel
        {
            ID = x.ID,
            Name = x.Name,
            CardNumber = x.CardNumber,
            Surname = x.Surname
        });

        return customer;
    }

    [HttpPost]

    public async Task Post(CustomerViewModel customer)
    {
        Customer newCustomer = new Customer
        {
            ID = customer.ID,
            Name = customer.Name,
            Surname = customer.Surname,
            CardNumber = customer.CardNumber
        };

        await _customerRepo.CreateAsync(newCustomer);

    }

    [HttpDelete("{id}")]
    public async Task Delete(Guid id)
    {
        await _customerRepo.DeleteAsync(id);
    }


    [HttpPut]
    public async Task<ActionResult> Put(CustomerViewModel newCustomerView)
    {
        var customerToUpdate = await _customerRepo.GetByIdAsync(newCustomerView.ID);
        if (customerToUpdate is null) return NotFound();


        customerToUpdate.Name = newCustomerView.Name;
        customerToUpdate.Surname = newCustomerView.Surname;
        customerToUpdate.CardNumber = newCustomerView.CardNumber;

        await _customerRepo.UpdateAsync(newCustomerView.ID, customerToUpdate);

        return Ok();
    }
}
