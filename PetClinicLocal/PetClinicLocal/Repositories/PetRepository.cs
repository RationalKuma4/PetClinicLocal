using System;
using System.Collections.Generic;
using PetClinicLocal.Contracts;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IPet;

namespace PetClinicLocal.Repositories
{
    public class PetRepository : IPetWriter, IPetReader
    {
        private readonly IPetService _service;
        public PetRepository(IPetService service)
        {
            _service = service;
        }

        public void RegistraMascota(Pet pet)
        {
            _service.AddPet(pet);
        }

        public Pet ModificaMascota(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void EliminaMascota(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet> VariasMascotas()
        {
            return _service.GetPets();
        }

        public Pet Mascota(int id)
        {
            throw new NotImplementedException();
        }
    }
}
