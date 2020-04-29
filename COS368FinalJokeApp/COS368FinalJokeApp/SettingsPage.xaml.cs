using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COS368FinalJokeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        async void OnDarkmodeToggled(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PrivacyPage());
        }

        async void Privacy_Cell_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrivacyPage());
        }

        async void OnLangTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LanguagePage());
        }

        async void OnPrivTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrivacyPage());
        }
    }
}