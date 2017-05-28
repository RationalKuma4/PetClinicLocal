using System.Collections.Generic;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IPet;
using PetClinicLocal.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PetClinicLocal.ViewModels.Mascota
{
    public class MainMascotaPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IPetReader _petReader;
        private readonly IAuthenticationService _authenticationService;

        public MainMascotaPageViewModel(INavigationService navigationService, IPetReader petReader,
            IAuthenticationService authenticationService)
        {
            _navigationService = navigationService;
            _petReader = petReader;
            _authenticationService = authenticationService;
            LogoutCommand = new DelegateCommand(OnLogoutCommandExecuted);
        }

        private string _petName;
        public string PetName
        {
            get { return _petName; }
            set { SetProperty(ref _petName, value); }
        }

        public IEnumerable<Pet> ListPets => _petReader.VariasMascotas();

        public DelegateCommand LogoutCommand { get; }

        public void OnLogoutCommandExecuted() =>
            _authenticationService.Logout();

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
