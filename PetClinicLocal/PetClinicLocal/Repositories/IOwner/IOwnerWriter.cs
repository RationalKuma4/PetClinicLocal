using PetClinicLocal.Models;

namespace PetClinicLocal.Repositories.IOwner
{
    public interface IOwnerWriter
    {
        void RegistraUsuario(OwnerUser owner);
        OwnerUser ModificaUsuario(OwnerUser user);
        void EliminaUsuario(int id);
    }
}