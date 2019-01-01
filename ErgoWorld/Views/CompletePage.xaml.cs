using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ErgoWorld.Views
{
    public partial class CompletePage : ContentPage
    {
        public CompletePage()
        {
            InitializeComponent();
        }

        private async void BtnHome (Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HomePage()); //Go to homepage
        }
    }
}
