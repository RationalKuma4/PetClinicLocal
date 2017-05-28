using System;
using System.Windows.Input;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IPet;
using PetClinicLocal.Services;
using PetClinicLocal.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace PetClinicLocal.ViewModels.Mascota
{
    public class AddMascotaPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IPetWriter _petWriter;
        private readonly IPageDialogService _dialogService;
        private readonly IAuthenticationService _authenticationService;

        public AddMascotaPageViewModel(INavigationService navigationService, IPetWriter petWriter, IPageDialogService dialogService,
            IAuthenticationService authenticationService)
        {
            _navigationService = navigationService;
            _petWriter = petWriter;
            _dialogService = dialogService;
            _authenticationService = authenticationService;
            LogoutCommand = new DelegateCommand(OnLogoutCommandExecuted);
        }

        public ICommand RegisterPetCommand => new Command(() =>
        {
            var newPet = new Pet
            {
                Name = Name,
                DateOfBirth = DateOfBirth,
                PlaceOfBirth = PlaceOfBirth,
                Age = Age,
                Weight = Weight,
                Height = Height,
                Sex = Sex,
                Breed = Breed,
                Colours = Colours,
                Observations = Observations
            };

            _petWriter.RegistraMascota(newPet);
            _dialogService.DisplayAlertAsync("Mensaje", "Mascota registrada", "OK");
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

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { SetProperty(ref _dateOfBirth, value); }
        }

        private string _placeofBirth;
        public string PlaceOfBirth
        {
            get { return _placeofBirth; }
            set { SetProperty(ref _placeofBirth, value); }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        private decimal _weight;
        public decimal Weight
        {
            get { return _weight; }
            set { SetProperty(ref _weight, value); }
        }

        private decimal _height;
        public decimal Height
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }

        private string _sex;
        public string Sex
        {
            get { return _sex; }
            set { SetProperty(ref _sex, value); }
        }

        private string _breed;
        public string Breed
        {
            get { return _breed; }
            set { SetProperty(ref _breed, value); }
        }

        private string _colours;
        public string Colours
        {
            get { return _colours; }
            set { SetProperty(ref _colours, value); }
        }

        private string _observations;
        public string Observations
        {
            get { return _observations; }
            set { SetProperty(ref _observations, value); }
        }
    }
}