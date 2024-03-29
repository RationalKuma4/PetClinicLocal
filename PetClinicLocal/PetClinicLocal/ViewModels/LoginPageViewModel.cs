﻿using System.Windows.Input;
using PetClinicLocal.Repositories.IOwner;
using PetClinicLocal.Views;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace PetClinicLocal.ViewModels
{
    public class LoginPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IOwnerReader _ownerReader;
        private readonly IPageDialogService _dialogService;

        public LoginPageViewModel(INavigationService navigationService, IOwnerReader ownerReader, IPageDialogService dialogService)
        {
            _navigationService = navigationService;
            _ownerReader = ownerReader;
            _dialogService = dialogService;
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
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                _dialogService.DisplayAlertAsync("Error", "Esribe usuario y contraseña", "OK");
                return;
            }

            var user = _ownerReader.LoginUser(Username, Password);

            if (user == null)
            {
                _dialogService.DisplayAlertAsync("Error", "Credendicales inavalidas", "OK");
                return;
            }
            App.User = user.UserName;
            _navigationService.NavigateAsync(ViewsNames.MasterMenuPageName);
        });

        public void OnNavigatedFrom(NavigationParameters parameters)
        { }

        public void OnNavigatedTo(NavigationParameters parameters)
        { }

        public void OnNavigatingTo(NavigationParameters parameters)
        { }

        private string _username = "hola";
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _password = "hola";
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
    }
}
