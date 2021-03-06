﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COS368FinalJokeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrivacyPage : ContentPage
    {
        public PrivacyPage()
        {
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Xamarin.Forms.Color.FromHex("F23333");
        }
    }
}