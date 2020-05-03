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
    public partial class FortniteJokesPage : ContentPage
    {
        public FortniteJokesPage()
        {
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CVJokes.ItemsSource = new JokeService().GetJokesListFortnite();
        }

        async void OnShareClicked(System.Object sender, System.EventArgs e)
        {
            await DisplayActionSheet("Share via", "Cancel", null, "SMS", "Email", "Twitter", "Facebook");
        }

        async void OnCommentClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CommentsPage(Title.Text));
        }

        async void OnJokesScrolled(System.Object sender, System.EventArgs e)
        {
            Dislike.BackgroundColor = Color.Transparent;
            Like.BackgroundColor = Color.Transparent;
        }

        async void OnHappyClicked(System.Object sender, System.EventArgs e)
        {
            Dislike.BackgroundColor = Color.Transparent;
            Like.BackgroundColor = Color.Blue;
        }

        async void OnSadClicked(System.Object sender, System.EventArgs e)
        {

            Like.BackgroundColor = Color.Transparent;
            Dislike.BackgroundColor = Color.Blue;
        }
    }
}