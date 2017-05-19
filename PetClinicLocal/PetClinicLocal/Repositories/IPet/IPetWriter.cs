using PetClinicLocal.Models;

namespace PetClinicLocal.Repositories.IPet
{
    public interface IPetWriter
    {
        void RegistraMascota(Pet pet);
        Pet ModificaMascota(Pet pet);
        void EliminaMascota(int id);
    }
}