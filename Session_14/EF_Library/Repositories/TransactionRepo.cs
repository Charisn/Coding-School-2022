using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;

namespace EF_Library.Repositories;

internal class TransactionRepo : IEntityRepo<Transaction>
{
    public async Task Create(Transaction entity)
    {
        using var context = new PetShopLibContext();
        context.Transactions.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        using var context = new PetShopLibContext();
        var foundTransaction = context.Transactions.SingleOrDefault(x => x.ID.Equals(id));
        if (foundTransaction is null)
            return;

        context.Transactions.Remove(foundTransaction);
        await context.SaveChangesAsync();
    }

    public List<Transaction> GetAll()
    {
        using var context = new PetShopLibContext();
        return context.Transactions.ToList();
    }

    public Transaction? GetById(Guid id)
    {
        using var context = new PetShopLibContext();
        return context.Transactions.Where(x => x.ID.Equals(id)).SingleOrDefault();
    }

    public async Task Update(Guid id, Transaction entity)
    {
        using var context = new PetShopLibContext();
        var foundTransaction = context.Transactions.Include(x => x.EmployeeID).Include(x => x.CustomerID).Include(x => x.PetID).Include(x => x.PetFoodID).Include(x => x.PetPrice).Include(x => x.PetFoodQty).Include(x => x.PetFoodPrice).Include(x => x.TotalPrice).SingleOrDefault(x => x.ID.Equals(id));
        if (foundTransaction is null)
            return;
        foundTransaction.Date = entity.Date;
        foundTransaction.EmployeeID = entity.EmployeeID;
        foundTransaction.PetID = entity.PetID;
        foundTransaction.PetFoodID = entity.PetFoodID;
        foundTransaction.PetPrice = entity.PetPrice;
        foundTransaction.PetFoodQty = entity.PetFoodQty;
        foundTransaction.PetFoodPrice = entity.PetFoodPrice;
        foundTransaction.TotalPrice = entity.TotalPrice;
        foundTransaction.CustomerID = entity.CustomerID;
        await context.SaveChangesAsync();
    }
}
