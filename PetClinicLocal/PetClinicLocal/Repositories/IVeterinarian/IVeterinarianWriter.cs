using PetClinicLocal.Models;

namespace PetClinicLocal.Repositories.IVeterinarian
{
    public interface IVeterinarianWriter
    {
        void RegistraVeterinario(Veterinarian veterinarian);
        Veterinarian ModificaVeterinario(Veterinarian veterinarian);
        void EliminaVeterinario(int id);
    }
}