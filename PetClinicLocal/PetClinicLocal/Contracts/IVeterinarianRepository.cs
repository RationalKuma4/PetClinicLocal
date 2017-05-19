using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Contracts
{
    public interface IVeterinarianRepository
    {
        void AddVeterinarian(Veterinarian veterinarian);
        Veterinarian UpdateVeterinarian(Veterinarian veterinarian);
        void RemoveVeterinarian(int id);
        IEnumerable<Veterinarian> GetVeterinarians();
        Veterinarian GetVeterinarian(int id);
    }
}
