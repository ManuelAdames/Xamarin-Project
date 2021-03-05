using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_INTEC.Views;
using Xamarin_INTEC.ViewModels;
using Xamarin_INTEC.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_INTEC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = new RegistrationViewModel();
        }
    }
}