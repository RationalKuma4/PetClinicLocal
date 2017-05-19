using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Contracts
{
    public interface IPetService
    {
        void AddPet(Pet pet);
        Pet UpdatePet(Pet pet);
        void RemovePet(int id);
        IEnumerable<Pet> GetPets();
        Pet GetPet(int id);
    }
}