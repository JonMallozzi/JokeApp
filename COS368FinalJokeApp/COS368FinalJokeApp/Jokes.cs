using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace COS368FinalJokeApp
{
    public class Joke
    {
        public string User { get; set; }
        public string Image { get; set; }
        public string Likes { get; set; }
        public string Comments { get; set; }
    }

    public class JokeService
    {
        public List<Joke> GetJokesList()
        {
            return new List<Joke>()
            {
                new Joke() { User="Trump2020Bruda", Image= "https://www.startupvitamins.com/media/products/10419/variant_1075.jpg?v1409313541", Likes="50K Likes", Comments="90 Comments" },
                new Joke() { User="FeelTheBern12", Image= "https://pics.me.me/michael-reeves-michaelreeves08-a-microwave-that-only-turns-on-when-60911566.png", Likes="5.5K Likes", Comments="89 Comments" },
                new Joke() { User="GamerBoy76", Image= "https://1stwebdesigner.com/wp-content/uploads/2015/09/web-designer-developer-jokes-humour-funny-40.jpg", Likes="10K Likes", Comments="100 Comments" },
                new Joke() { User="Homerman12", Image= "https://i.pinimg.com/originals/0a/50/e4/0a50e43751ee7497d407c4642c85757e.jpg", Likes="2K Likes", Comments="76 Comments" },
                new Joke() { User="Cornchips", Image= "https://starecat.com/content/wp-content/uploads/pregnant-woman-smoking-drinking-no-it-doesnt-affect-my-baby-12-years-later-kid-playing-fortnite.jpg", Likes="2.5K Likes", Comments="120 Comments" }
            };
        }
    }
}
