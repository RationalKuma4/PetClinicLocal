using System.Collections.Generic;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IVeterinarian;
using PetClinicLocal.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PetClinicLocal.ViewModels.Veterinario
{
    public class MainVeterinarioPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IVeterinarianReader _vetReader;
        private readonly IAuthenticationService _authenticationService;

        public MainVeterinarioPageViewModel(INavigationService navigationService, IVeterinarianReader vetReader,
            IAuthenticationService authenticationService)
        {
            _navigationService = navigationService;
            _vetReader = vetReader;
            _authenticationService = authenticationService;
            LogoutCommand = new DelegateCommand(OnLogoutCommandExecuted);
        }

        public IEnumerable<Veterinarian> ListVets => _vetReader.VariosVeterinarios();

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

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _clinicAddress;
        public string ClinicAddress
        {
            get { return _clinicAddress; }
            set { SetProperty(ref _clinicAddress, value); }
        }

        private string _clinicName;
        public string ClinicName
        {
            get { return _clinicName; }
            set { SetProperty(ref _clinicName, value); }
        }
    }
}
