using System.Windows.Input;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IVeterinarian;
using PetClinicLocal.Services;
using PetClinicLocal.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace PetClinicLocal.ViewModels.Veterinario
{
    public class AddVeterinarioPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IVeterinarianWriter _vetWriter;
        private readonly IPageDialogService _dialogService;
        private readonly IAuthenticationService _authenticationService;

        public AddVeterinarioPageViewModel(INavigationService navigationService, IVeterinarianWriter vetWriter,
            IPageDialogService dialogService, IAuthenticationService authenticationService)
        {
            _navigationService = navigationService;
            _vetWriter = vetWriter;
            _dialogService = dialogService;
            _authenticationService = authenticationService;
            LogoutCommand = new DelegateCommand(OnLogoutCommandExecuted);
        }

        public ICommand RegisterVetCommand => new Command(() =>
        {
            var newVet = new Veterinarian
            {
                Name = Name,
                Lastname = Lastname,
                ClinicName = ClinicName,
                ClinicAddress = ClinicAddress,
                ServiceHours = ServiceHours,
                Telephone = Telephone,
                Email = Email,
                Observations = Observations
            };

            _vetWriter.RegistraVeterinario(newVet);
            _dialogService.DisplayAlertAsync("Mensaje", "Veterinario Registrado", "OK");
            _navigationService.NavigateAsync(ViewsNames.MasterMenuPageName);
        });

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

        private string _lastname;
        public string Lastname
        {
            get { return _lastname; }
            set { SetProperty(ref _lastname, value); }
        }

        private string _clinicName;
        public string ClinicName
        {
            get { return _clinicName; }
            set { SetProperty(ref _clinicName, value); }
        }

        private string _clinicAddress;
        public string ClinicAddress
        {
            get { return _clinicAddress; }
            set { SetProperty(ref _clinicAddress, value); }
        }
        private string _serviceHours;
        public string ServiceHours
        {
            get { return _serviceHours; }
            set { SetProperty(ref _serviceHours, value); }
        }
        private string _telephone;
        public string Telephone
        {
            get { return _telephone; }
            set { SetProperty(ref _telephone, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _observations;
        public string Observations
        {
            get { return _observations; }
            set { SetProperty(ref _observations, value); }
        }
    }
}
