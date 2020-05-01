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
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }


        async void OnSearchClicked(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SearchResultPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}