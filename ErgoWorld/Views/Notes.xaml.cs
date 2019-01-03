using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ErgoWorld.Views.NoteDetails;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ErgoWorld.Views
{
    public partial class Notes : ContentPage
    {
        public Notes()
        {
            InitializeComponent();
            NoteList.ItemsSource = new List<SingleNote>() {
                new SingleNote()
                {
                    Heading = "Hjertet",
                    Date = "31-09-2018",
                    Text = "Hjertet består af fire hjertekamre: Forkamre og hovedkamre. Forkamrene kaldes også atrier. Hovedkamrene kaldes også hjertekamre eller ventrikler",
                },

                new SingleNote()
                {
                    Heading = "Nyren",
                    Date = "07-11-2018",
                    Text = "Nyrekræft opstår i nyrerne. I nyrerne dannes urin, som via urinlederne ledes videre ned til blæren. Nyrerne ligger på hver sin side af rygsøjlen, opadtil bagest i bughulen.",
                },

                new SingleNote()
                {
                    Heading = "Triceps",
                    Date = "10-12-2018",
                    Text = "Triceps er den store muskel der sidder bag på overarmen og går fra skulderen til den nederste del af overarmen. Triceps hovedfunktion er at strække armen ud",
                },
            };
        }

        private void NoteTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

        }

        public void OnDelete(object sender, System.EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Noten slettes", mi.CommandParameter + " slettes fra noter", "OK");
        }
    }

    public class SingleNote
    {
        public string Heading { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
    }
}