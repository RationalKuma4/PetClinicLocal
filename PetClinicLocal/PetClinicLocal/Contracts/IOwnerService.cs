using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Contracts
{
    public interface IOwnerService
    {
        void AddOwner(OwnerUser user);
        OwnerUser UpdateOwnerUser(OwnerUser user);
        void RemoveOwnerUser(int id);
        IEnumerable<OwnerUser> GetOwnerUsers();
        OwnerUser GetOwnerUser(int id);
    }
}
