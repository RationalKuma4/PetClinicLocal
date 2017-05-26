using System.Windows.Input;
using PetClinicLocal.Helpers;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IOwner;
using PetClinicLocal.Views;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace PetClinicLocal.ViewModels.Usuario
{
    public class ResgisterUserPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IOwnerWriter _ownerWriter;
        public ResgisterUserPageViewModel(INavigationService navigationService, IOwnerWriter ownerWriter)
        {
            _navigationService = navigationService;
            _ownerWriter = ownerWriter;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        { }

        public void OnNavigatedTo(NavigationParameters parameters)
        { }

        public void OnNavigatingTo(NavigationParameters parameters)
        { }

        public ICommand RegisterUserCommand => new Command(() =>
        {
            if (!VerificaContrasena(Password, PasswordRep)) return;
            var newUser = new OwnerUser
            {
                Name = Nombre,
                LastName = Nombre,
                Password = Password,
                UserName = Username
            };
            _ownerWriter.RegistraUsuario(newUser);
            Settings.Current.UserName = newUser.UserName;
            _navigationService.NavigateAsync(ViewsNames.MasterMenuPageName);
        });

        private bool VerificaContrasena(string password, string passwordRep)
        {
            return password.Equals(passwordRep);
        }

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

        private string _passwordRep;
        public string PasswordRep
        {
            get { return _passwordRep; }
            set { SetProperty(ref _passwordRep, value); }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
    }
}
