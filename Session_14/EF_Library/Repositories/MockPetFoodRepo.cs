using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library.Repositories;

internal class MockPetFoodRepo
{
    private List<PetFood> _petFoods = new List<PetFood>() { new PetFood(), new PetFood() };

    public Task Create(PetFood entity)
    {
        _petFoods.Add(entity);
        return Task.CompletedTask;
    }

    public Task Delete(int id)
    {
        var foundPetFood = _petFoods.SingleOrDefault(x => x.ID.Equals(id));
        if (foundPetFood is null)
            return Task.CompletedTask;
        _petFoods.Remove(foundPetFood);
        return Task.CompletedTask;
    }

    public List<PetFood> GetAll()
    {
        return _petFoods;
    }

    public PetFood? GetById(int id)
    {
        return _petFoods.SingleOrDefault(x => x.ID.Equals(id));
    }

    public Task Update(int id, PetFood entity)
    {
        var foundPetFood = _petFoods.SingleOrDefault(x => x.ID.Equals(id));
        if (foundPetFood is null)
            return Task.CompletedTask;
        foundPetFood.AnimalType = entity.AnimalType;
        foundPetFood.Cost = entity.Cost;
        foundPetFood.Price = entity.Price;
        return Task.CompletedTask;
    }
}
