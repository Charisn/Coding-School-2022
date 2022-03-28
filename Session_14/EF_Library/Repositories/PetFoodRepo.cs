using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library.Repositories;

public class PetFoodRepo : IEntityRepo<PetFood>
{
    public async Task Create(PetFood entity)
    {
        using var context = new PetShopLibContext();
        context.PetFoods.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        using var context = new PetShopLibContext();
        var foundPetFood = context.PetFoods.SingleOrDefault(x => x.ID.Equals(id));
        if (foundPetFood is null)
            return;

        context.PetFoods.Remove(foundPetFood);
        await context.SaveChangesAsync();
    }

    public List<PetFood> GetAll()
    {
        using var context = new PetShopLibContext();
        return context.PetFoods.ToList();
    }

    public PetFood? GetById(Guid id)
    {
        using var context = new PetShopLibContext();
        return context.PetFoods.Where(x => x.ID.Equals(id)).SingleOrDefault();
    }

    public async Task Update(Guid id, PetFood entity)
    {
        using var context = new PetShopLibContext();
        var foundPetFood = context.PetFoods.Include(x => x.AnimalType).Include(x => x.Cost).Include(x => x.Price).SingleOrDefault(x => x.ID.Equals(id));
        if (foundPetFood is null)
            return;
        foundPetFood.AnimalType = entity.AnimalType;
        foundPetFood.Cost = entity.Cost;
        foundPetFood.Price = entity.Price;
        await context.SaveChangesAsync();
    }
}
