using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_INTEC.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_INTEC.ViewModels
{
    class RegistrationViewModel
    {
    public ICommand RegistrationCommand { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public RegistrationViewModel()
        {
            RegistrationCommand = new Command(OnRegistrationTap);
        }
        private async void OnRegistrationTap()
        {
            {
                if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(ConfirmPassword))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Ningun campo puede estar vacio", "Ok");
                }
                else if (Password != ConfirmPassword)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Las contraseñas deben ser iguales", "Ok");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + Name, "Ok");
                    await App.Current.MainPage.Navigation.PushModalAsync(new HomePage());
                }
            }
        }
    }
}
