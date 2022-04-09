using FuelStation.EF.Context;
using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories;

public class TransactionLineRepo : IEntityRepo<TransactionLine>
{
    private readonly FuelStationContext _context;
    public TransactionLineRepo(FuelStationContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(TransactionLine entity)
    {

        await _context.TransactionLines.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var foundTLine = await _context.TransactionLines.SingleOrDefaultAsync(tLine => tLine.ID == id);
        if (foundTLine is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        _context.TransactionLines.Remove(foundTLine);
        await _context.SaveChangesAsync();
    }

    public async Task<List<TransactionLine>> GetAllAsync()
    {

        return await _context.TransactionLines.ToListAsync();
    }

    public async Task<TransactionLine?> GetByIdAsync(Guid id)
    {
        return await _context.TransactionLines.Where(tLine => tLine.ID == id).SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(Guid id, TransactionLine entity)
    {
        var foundTLine = await _context.TransactionLines.SingleOrDefaultAsync(tLine => tLine.ID == id);

        if (foundTLine is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundTLine.TransactionID = entity.TransactionID;
        foundTLine.ItemID = entity.ItemID;
        foundTLine.Quantity = entity.Quantity;
        foundTLine.ItemPrice = entity.ItemPrice;
        foundTLine.NetValue = entity.NetValue;
        foundTLine.DiscountPercentage = entity.DiscountPercentage;
        foundTLine.DiscountValue = entity.DiscountValue;
        foundTLine.TotalValue = entity.TotalValue;
        await _context.SaveChangesAsync();
    }
}
