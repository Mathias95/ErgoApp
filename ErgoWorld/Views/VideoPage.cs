using System;

using Xamarin.Forms;

namespace ErgoWorld.Views
{
    public class VideoPage : ContentPage
    {
        public VideoPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

