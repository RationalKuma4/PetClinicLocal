using System.Collections.Generic;
using PetClinicLocal.Contracts;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IVeterinarian;

namespace PetClinicLocal.Repositories
{
    public class VeterinarianRepository : IVeterinarianWriter, IVeterinarianReader
    {
        private readonly IVeterinarianService _service;
        public VeterinarianRepository(IVeterinarianService service)
        {
            _service = service;
        }

        public void RegistraVeterinario(Veterinarian veterinarian)
        {
            _service.AddVeterinarian(veterinarian);
        }

        public Veterinarian ModificaVeterinario(Veterinarian veterinarian)
        {
            throw new System.NotImplementedException();
        }

        public void EliminaVeterinario(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Veterinarian> VariosVeterinarios()
        {
            return _service.GetVeterinarians();
        }

        public Veterinarian Veterinarop(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
