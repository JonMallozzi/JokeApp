using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.FilePicker;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COS368FinalJokeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecoveryPage : ContentPage
    {
        public RecoveryPage()
        {
            InitializeComponent();
        }

        async void OnResetTapped(Object sender, EventArgs args)
        {
            // user gets the password recovery email
        }

    }
}