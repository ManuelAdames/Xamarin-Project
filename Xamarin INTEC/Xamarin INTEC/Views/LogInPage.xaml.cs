using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_INTEC.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_INTEC.ViewModels;
using Xamarin_INTEC.Models;

namespace Xamarin_INTEC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
            BindingContext = new LogInViewModel();
        }
    }
}