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
            throw new NotImplementedException();
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
            return new List<Pet>
            {
                new Pet {OwnerUserId = 1,Age = 1,PetId = 1,Breed = "hola",Name = "hola"},
                new Pet {OwnerUserId = 1,Age = 1,PetId = 1,Breed = "hola",Name = "hola2"}
            };
        }

        public Pet Mascota(int id)
        {
            throw new NotImplementedException();
        }
    }
}
