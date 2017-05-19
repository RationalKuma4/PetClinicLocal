using System.Windows.Input;
using PetClinicLocal.Helpers;
using PetClinicLocal.Repositories.IOwner;
using PetClinicLocal.Views;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace PetClinicLocal.ViewModels
{
    public class LoginPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IOwnerReader _ownerReader;

        public LoginPageViewModel(INavigationService navigationService, IOwnerReader ownerReader)
        {
            _navigationService = navigationService;
            _ownerReader = ownerReader;
        }

        public ICommand NavCommand
        {
            get
            {
                return new Command(() =>
                {
                    _navigationService.NavigateAsync(ViewsNames.ResgisterUserPageName);
                });
            }
        }

        public ICommand LoginCommand => new Command(() =>
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password)) return;
            var user = _ownerReader.LoginUser(Username, Password);

            if (user == null) return;
            Settings.User = Username;
            Settings.Password = Password;

            //_navigationService.NavigateAsync(ViewsNames)
        });

        public void OnNavigatedFrom(NavigationParameters parameters)
        { }

        public void OnNavigatedTo(NavigationParameters parameters)
        { }

        public void OnNavigatingTo(NavigationParameters parameters)
        { }

        private string _username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
    }
}
