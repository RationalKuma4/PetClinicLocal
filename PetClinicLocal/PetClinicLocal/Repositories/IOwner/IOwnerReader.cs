using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Repositories.IOwner
{
    public interface IOwnerReader
    {
        IEnumerable<OwnerUser> RegresaUsuarios(OwnerUser user);
        OwnerUser RegresaUsuario(int id);
    }
}