using System;
using System.Collections.Generic;
using PetClinicLocal.Contracts;
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
            throw new NotImplementedException();
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
    }
}
