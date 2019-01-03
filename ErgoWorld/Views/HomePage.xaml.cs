using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ErgoWorld.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void BtnVideo(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new VideoPage()); //Go to VideoPage
        }
        private async void BtnNotes(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Notes()); //Go to NotePage
        }
        private async void BtnQuiz(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new QuizPage()); //Go to QuizPage
        }
    }
}

//Alternative navigation