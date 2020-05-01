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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CVJokes.ItemsSource = new JokeService().GetJokesList();
        }

        async void OnShareClicked(System.Object sender, System.EventArgs e)
        {
            //  await Navigation.PushModalAsync(new ShareModal());
            string action = await DisplayActionSheet("Share via", "Cancel", null, "SMS", "Email", "Twitter", "Facebook");
          
        }

        async void OnCommentClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CommentsPage());

        }
    }
}