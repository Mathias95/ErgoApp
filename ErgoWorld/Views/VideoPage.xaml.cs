using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ErgoWorld.Views
{
    public partial class VideoPage : ContentPage
    {
        public VideoPage()
        {
            InitializeComponent();
        }
        private async void BtnNext(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ScenarioPageOne()); //Go to ScenarioPageOne
        }
    }
}
