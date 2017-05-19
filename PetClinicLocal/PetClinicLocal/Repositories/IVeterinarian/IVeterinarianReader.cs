using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Repositories.IVeterinarian
{
    public interface IVeterinarianReader
    {
        IEnumerable<Veterinarian> VariosVeterinarios();
        Veterinarian Veterinarop(int id);
    }
}