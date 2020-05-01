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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        async void OnForgotTapped(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RecoveryPage());
        }

        async void OnLoginTapped(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NavPage());
        }

    }
}