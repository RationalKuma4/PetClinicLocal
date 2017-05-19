using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Repositories.IPet
{
    public interface IPetReader
    {
        IEnumerable<Pet> VariasMascotas();
        Pet Mascota(int id);
    }
}