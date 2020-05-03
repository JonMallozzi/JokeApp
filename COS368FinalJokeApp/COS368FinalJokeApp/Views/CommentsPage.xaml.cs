using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace COS368FinalJokeApp
{
    public partial class CommentsPage : ContentPage {
        public CommentsPage(string title)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
            LoadComments(title);
            Title.Text = title + " Comments";
            
        }

        private void LoadComments(string title) {
            Comments comments = new Comments();

            //this would be a thousand times better with an api 
            if (title.Equals("Feed")) {

                User.Text = comments.comments.Feed[0].username;
                Comment.Text = comments.comments.Feed[0].comment;
                User1.Text = comments.comments.Feed[1].username;
                Comment1.Text = comments.comments.Feed[1].comment;
                User2.Text = comments.comments.Feed[2].username;
                Comment2.Text = comments.comments.Feed[2].comment;
                User3.Text = comments.comments.Feed[3].username;
                Comment3.Text = comments.comments.Feed[3].comment;
                User4.Text = comments.comments.Feed[4].username;
                Comment4.Text = comments.comments.Feed[4].comment;
                User5.Text = comments.comments.Feed[5].username;
                Comment5.Text = comments.comments.Feed[5].comment;
                User6.Text = comments.comments.Feed[6].username;
                Comment6.Text = comments.comments.Feed[6].comment;

            }
            else if (title.Equals("Sports")) {
                User.Text = comments.comments.Sports[0].username;
                Comment.Text = comments.comments.Sports[0].comment;
                User1.Text = comments.comments.Sports[1].username;
                Comment1.Text = comments.comments.Sports[1].comment;
                User2.Text = comments.comments.Sports[2].username;
                Comment2.Text = comments.comments.Sports[2].comment;
                User3.Text = comments.comments.Sports[3].username;
                Comment3.Text = comments.comments.Sports[3].comment;
                User4.Text = comments.comments.Sports[4].username;
                Comment4.Text = comments.comments.Sports[4].comment;
                User5.Text = comments.comments.Sports[5].username;
                Comment5.Text = comments.comments.Sports[5].comment;
                User6.Text = comments.comments.Sports[6].username;
                Comment6.Text = comments.comments.Sports[6].comment;

            }
            else if (title.Equals("Fortnite")) {
                User.Text = comments.comments.Fortnite[0].username;
                Comment.Text = comments.comments.Fortnite[0].comment;
                User1.Text = comments.comments.Fortnite[1].username;
                Comment1.Text = comments.comments.Fortnite[1].comment;
                User2.Text = comments.comments.Fortnite[2].username;
                Comment2.Text = comments.comments.Fortnite[2].comment;
                User3.Text = comments.comments.Fortnite[3].username;
                Comment3.Text = comments.comments.Fortnite[3].comment;
                User4.Text = comments.comments.Fortnite[4].username;
                Comment4.Text = comments.comments.Fortnite[4].comment;
                User5.Text = comments.comments.Fortnite[5].username;
                Comment5.Text = comments.comments.Fortnite[5].comment;
                User6.Text = comments.comments.Fortnite[6].username;
                Comment6.Text = comments.comments.Fortnite[6].comment;
            }
            else {
                User.Text = comments.comments.DadJokes[0].username;
                Comment.Text = comments.comments.DadJokes[0].comment;
                User1.Text = comments.comments.DadJokes[1].username;
                Comment1.Text = comments.comments.DadJokes[1].comment;
                User2.Text = comments.comments.DadJokes[2].username;
                Comment2.Text = comments.comments.DadJokes[2].comment;
                User3.Text = comments.comments.DadJokes[3].username;
                Comment3.Text = comments.comments.DadJokes[3].comment;
                User4.Text = comments.comments.DadJokes[4].username;
                Comment4.Text = comments.comments.DadJokes[4].comment;
                User5.Text = comments.comments.DadJokes[5].username;
                Comment5.Text = comments.comments.DadJokes[5].comment;
                User6.Text = comments.comments.DadJokes[6].username;
                Comment6.Text = comments.comments.DadJokes[6].comment;
            }
        }
    }
}
