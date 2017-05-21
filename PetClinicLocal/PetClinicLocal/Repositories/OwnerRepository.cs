using System;
using System.Collections.Generic;
using System.Linq;
using PetClinicLocal.Contracts;
using PetClinicLocal.Helpers;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IOwner;

namespace PetClinicLocal.Repositories
{
    public class OwnerRepository : IOwnerWriter, IOwnerReader
    {
        private readonly IOwnerService _service;

        public OwnerRepository(IOwnerService service)
        {
            _service = service;
        }

        public void RegistraUsuario(OwnerUser owner)
        {
            _service.AddOwner(owner);
        }

        public OwnerUser ModificaUsuario(OwnerUser user)
        {
            throw new NotImplementedException();
        }

        public void EliminaUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OwnerUser> RegresaUsuarios(OwnerUser user)
        {
            throw new NotImplementedException();
        }

        public OwnerUser RegresaUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public OwnerUser LoginUser(string usuario, string password)
        {
            var owner = _service
                .GetOwnerUsers()
                .FirstOrDefault(u => u.UserName.Equals(usuario) && u.Password.Equals(password));
            if (owner == null) return null;
            Settings.User = owner.UserName;
            return owner;
        }
    }
}
