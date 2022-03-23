using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library.Repositories;

internal class MockupPetRepo
{
    private List<Pet> _pet = new List<Pet>() { new Pet(), new Pet() };

    public Task Create(Pet entity)
    {
        _pet.Add(entity);
        return Task.CompletedTask;
    }

    public Task Delete(int id)
    {
        var foundPet = _pet.SingleOrDefault(x => x.ID.Equals(id));
        if (foundPet is null)
            return Task.CompletedTask;
        _pet.Remove(foundPet);
        return Task.CompletedTask;
    }

    public List<Pet> GetAll()
    {
        return _pet;
    }

    public Pet? GetById(int id)
    {
        return _pet.SingleOrDefault(x => x.ID.Equals(id));
    }

    public Task Update(int id, Pet entity)
    {
        var foundPet = _pet.SingleOrDefault(x => x.ID.Equals(id));
        if (foundPet is null)
            return Task.CompletedTask;
        foundPet.AnimalType = entity.AnimalType;
        foundPet.Cost = entity.Cost;
        foundPet.Price = entity.Price;
        foundPet.Breed = entity.Breed;
        foundPet.PetStatus = entity.PetStatus;
        return Task.CompletedTask;
    }
}

