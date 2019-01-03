using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ErgoWorld.Views
{
    public partial class QuizPage : ContentPage
    {
        public QuizPage()
        {
            InitializeComponent();

            BtnForward.Clicked += (s, e) => Navigation.PushAsync(new CompletePage());

            QuizList.ItemsSource = new List<QuizAnswer>()
            {
                new QuizAnswer()
                {
                    Answer = "Kroppen forsøger at aflaste hjertet ved at sænke puls og SV"
                },
                new QuizAnswer()
                {
                    Answer = "Aktivering af sympatikus og renin-angiotensin-aldosteronsys",
                },
                new QuizAnswer()
                {
                    Answer = "Nedsætter preload hvorved hjertet aflastes",
                },
                new QuizAnswer()
                {
                    Answer = "Ventrikelremodellering (hypertrofi/dialatation)",
                },
            };
        }
    }

    public class QuizAnswer
    {
        public string Answer { get; set; }
        public bool Selected { get; set; }
    }
}
