using System;
using System.Linq;
using System.Windows.Input;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IAppointment;
using PetClinicLocal.Repositories.IPet;
using PetClinicLocal.Repositories.IVeterinarian;
using PetClinicLocal.Services;
using PetClinicLocal.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace PetClinicLocal.ViewModels.Cita
{
    public class AddCitaPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IAppointmentWriter _appointmentWriter;
        private readonly IPageDialogService _dialogService;
        private readonly IAuthenticationService _authenticationService;
        private readonly IPetReader _petReader;
        private readonly IVeterinarianReader _veterinarianReader;

        public AddCitaPageViewModel(INavigationService navigationService, IAppointmentWriter appointmentWriter,
            IPageDialogService dialogService, IAuthenticationService authenticationService, IPetReader petReader,
            IVeterinarianReader veterinarianReader)
        {
            _navigationService = navigationService;
            _appointmentWriter = appointmentWriter;
            _dialogService = dialogService;
            _authenticationService = authenticationService;
            LogoutCommand = new DelegateCommand(OnLogoutCommandExecuted);
            _petReader = petReader;
            _veterinarianReader = veterinarianReader;
        }

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


        public ICommand RegisterAppointmentCommand => new Command(() =>
        {
            if (string.IsNullOrWhiteSpace(PetName) || string.IsNullOrWhiteSpace(VetName))
            {
                _dialogService.DisplayAlertAsync("Mensaje", "Introduzca el nombre de la mascota y del veterinario", "OK");
                return;
            }

            var petId = _petReader
                .VariasMascotas()
                .FirstOrDefault(p => p.Name.Contains(PetName));
            var vetId = _veterinarianReader
                .VariosVeterinarios()
                .FirstOrDefault(v => v.Name.Contains(VetName));

            if (petId == null || vetId == null)
            {
                _dialogService.DisplayAlertAsync("Mensaje", "La mascota o el veterinario no existen", "OK");
                return;
            }

            var newApp = new Appointment
            {
                DateAppointment = DateAppointment,
                Completed = false,
                AppointmentType = Models.Enums.AppointmentType.Vacuna,
                Observations = Observations,
                PetId = petId.PetId,
                VeterinarianId = vetId.VeterinarianId
            };

            _appointmentWriter.RegistraCita(newApp);
            _dialogService.DisplayAlertAsync("Mensaje", "Nueva Cita registrada", "OK");
            _navigationService.NavigateAsync(ViewsNames.MasterMenuPageName);
        });

        private DateTime _dateAppointment;
        public DateTime DateAppointment
        {
            get { return _dateAppointment; }
            set { SetProperty(ref _dateAppointment, value); }
        }

        private string _appointmentType;
        public string AppointmentType
        {
            get { return _appointmentType; }
            set { SetProperty(ref _appointmentType, value); }
        }

        private string _observations;
        public string Observations
        {
            get { return _observations; }
            set { SetProperty(ref _observations, value); }
        }

        private string _petName;
        public string PetName
        {
            get { return _petName; }
            set { SetProperty(ref _petName, value); }
        }

        private string _vetName;
        public string VetName
        {
            get { return _vetName; }
            set { SetProperty(ref _vetName, value); }
        }
    }
}
