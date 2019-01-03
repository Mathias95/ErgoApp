using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ErgoWorld.Views
{
    public partial class ScenarioPageOne : ContentPage
    {
        public ScenarioPageOne()
        {
            InitializeComponent();
        }
        private async void BtnNext(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ScenarioPageTwo()); //Go to ScenarioPageTwo
        }
    }
}
