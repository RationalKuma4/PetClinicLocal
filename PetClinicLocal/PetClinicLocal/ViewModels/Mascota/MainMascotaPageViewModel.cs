using System.Collections.Generic;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IPet;
using Prism.Mvvm;
using Prism.Navigation;

namespace PetClinicLocal.ViewModels.Mascota
{
    public class MainMascotaPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IPetReader _petReader;

        public MainMascotaPageViewModel(INavigationService navigationService, IPetReader petReader)
        {
            _navigationService = navigationService;
            _petReader = petReader;
        }

        private string _petName;

        public string PetName
        {
            get { return _petName; }
            set { SetProperty(ref _petName, value); }
        }

        public IEnumerable<Pet> ListPets => _petReader.VariasMascotas();


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
