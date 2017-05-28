using System.Collections.Generic;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IAppointment;
using PetClinicLocal.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace PetClinicLocal.ViewModels.Cita
{
    public class MainCitaPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IAppointmentReader _appointmentReader;
        private readonly IPageDialogService _dialogService;
        private readonly IAuthenticationService _authenticationService;

        public MainCitaPageViewModel(INavigationService navigationService, IAppointmentReader appointmentReader,
            IPageDialogService dialogService, IAuthenticationService authenticationService)
        {
            _navigationService = navigationService;
            _appointmentReader = appointmentReader;
            _dialogService = dialogService;
            _authenticationService = authenticationService;
            LogoutCommand = new DelegateCommand(OnLogoutCommandExecuted);
        }

        public IEnumerable<Appointment> Appointments => _appointmentReader.VariasCitas();

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public DelegateCommand LogoutCommand { get; }

        public void OnLogoutCommandExecuted() => _authenticationService.Logout();
    }
}
