using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Contracts
{
    public interface IPetRepository
    {
        void AddPet(Pet pet);
        Pet UpdatePet(Pet pet);
        void RemovePet(int id);
        IEnumerable<Pet> GetPets();
        Pet GetPet(int id);
    }
}