using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLib.Impl;


namespace EF_Library.Repositories;

internal class MockTransactionRepo
{
    private List<Transaction> _transactions = new List<Transaction>() { new Transaction(), new Transaction() };

    public Task Create(Transaction entity)
    {
        _transactions.Add(entity);
        return Task.CompletedTask;
    }

    public Task Delete(int id)
    {
        var foundTransaction = _transactions.SingleOrDefault(x => x.ID.Equals(id));
        if (foundTransaction is null)
            return Task.CompletedTask;
        _transactions.Remove(foundTransaction);
        return Task.CompletedTask;
    }

    public List<Transaction> GetAll()
    {
        return _transactions;
    }

    public Transaction? GetById(int id)
    {
        return _transactions.SingleOrDefault(x => x.ID.Equals(id));
    }

    public Task Update(int id, Transaction entity)
    {
        var foundTransaction = _transactions.SingleOrDefault(x => x.ID.Equals(id));
        if (foundTransaction is null)
            return Task.CompletedTask;
        foundTransaction.Date = entity.Date;
        foundTransaction.EmployeeID = entity.EmployeeID;
        foundTransaction.PetID = entity.PetID;
        foundTransaction.PetFoodID = entity.PetFoodID;
        foundTransaction.PetPrice = entity.PetPrice;
        foundTransaction.PetFoodQty = entity.PetFoodQty;
        foundTransaction.PetFoodPrice = entity.PetFoodPrice;
        foundTransaction.TotalPrice = entity.TotalPrice;
        return Task.CompletedTask;
    }
}
