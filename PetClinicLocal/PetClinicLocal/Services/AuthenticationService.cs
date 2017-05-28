using System;
using PetClinicLocal.Contracts;
using PetClinicLocal.Views;
using Prism.Navigation;

namespace PetClinicLocal.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IOwnerService _ownerService;
        private readonly INavigationService _navigationService;

        public AuthenticationService(IOwnerService ownerService, INavigationService navigationService)
        {
            _ownerService = ownerService;
            _navigationService = navigationService;
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            _navigationService.NavigateAsync(ViewsNames.LoginPageName);
        }
    }
}
