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
    public partial class UploadPage : ContentPage
    {
        public UploadPage()
        {
            InitializeComponent();
        }

        async void OnUploadTapped(Object sender, EventArgs args)
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                lbl.Text = file.FileName;
            }
        }
    }
}