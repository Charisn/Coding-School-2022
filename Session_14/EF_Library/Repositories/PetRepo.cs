using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library.Repositories;

internal class PetRepo : IEntityRepo<Pet>
{
    public async Task Create(Pet entity)
    {
        using var context = new PetShopLibContext();
        context.Pets.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        using var context = new PetShopLibContext();
        var foundPet = context.Pets.SingleOrDefault(x => x.ID.Equals(id));
        if (foundPet is null)
            return;

        context.Pets.Remove(foundPet);
        await context.SaveChangesAsync();
    }

    public List<Pet> GetAll()
    {
        using var context = new PetShopLibContext();
        return context.Pets.ToList();
    }

    public Pet? GetById(Guid id)
    {
        using var context = new PetShopLibContext();
        return context.Pets.Where(x => x.ID.Equals(id)).SingleOrDefault();
    }

    public async Task Update(Guid id, Pet entity)
    {
        using var context = new PetShopLibContext();
        var foundPet = context.Pets.Include(x => x.AnimalType).Include(x => x.Cost).Include(x => x.Price).Include(x => x.Breed).Include(x => x.Breed).SingleOrDefault(x => x.ID.Equals(id));
        if (foundPet is null)
            return;
        foundPet.AnimalType = entity.AnimalType;
        foundPet.Cost = entity.Cost;
        foundPet.Price = entity.Price;
        foundPet.Breed = entity.Breed;
        foundPet.PetStatus = entity.PetStatus;
        await context.SaveChangesAsync();
    }
}
