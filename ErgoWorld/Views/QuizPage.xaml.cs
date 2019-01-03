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

            QuizList.ItemsSource = new List<QuizAnswer>()
            {
                new QuizAnswer()
                {
                    Answer = "Kroppen forsøger at aflaste hjertet ved at sænke puls og SV"
                },
                new QuizAnswer()
                {
                    Answer = "Aktivering af sympatikus og renin-angiotensin-aldosteronsys\nThis is a correct answer\n",
                },
                new QuizAnswer()
                {
                    Answer = "Nedsætter preload hvorved hjertet aflastes\\nThis is a wrong answer\\n",
                },
                new QuizAnswer()
                {
                    Answer = "Ventrikelremodellering (hypertrofi/dialatation)\nThis is a correct answer\n",
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
