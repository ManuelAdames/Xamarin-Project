using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_INTEC.Views;

namespace Xamarin_INTEC.ViewModels
{
    public class LogInViewModel
    {
        public ICommand LogInCommand { get; }
        public ICommand SignUpCommand { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public LogInViewModel()
        {
            LogInCommand = new Command(OnLogin);
            SignUpCommand = new Command(OnRegistration);
        }

        private async void OnLogin()
        {
            if (String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Campos email y/o contraseña no pueden estar vacíos", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + Email, "Ok");
                await App.Current.MainPage.Navigation.PushModalAsync(new HomePage());
            }
        }

        private async void OnRegistration()
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new RegistrationPage());
        }
    }
}

