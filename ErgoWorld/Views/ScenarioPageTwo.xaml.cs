using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ErgoWorld.Views
{
    public partial class ScenarioPageTwo : ContentPage
    {
        public ScenarioPageTwo()
        {
            InitializeComponent();
        }
        private async void BtnNext(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CompletePage()); //Go to Complete
        }
    }
}
