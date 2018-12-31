using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ErgoWorld.Views
{
    public partial class SearchPage : ContentPage
    {
        private readonly List<string> _lectures = new List<string>
        {
            "Det levende legeme", "Skeletsystemet", "Muskelsystemet", "Nervesystemet", "Hormonsystemet", "Kardiovaskulærsystemet", "Åndedrætssystemet", "Integumentærsystemet", "Immun og lymfesystemet", "Fordøjelsessystemet", "Urinvejssystemet", "Forplantningssystemet", "Farmakologi"
        };

        public SearchPage()
        {
            InitializeComponent();

            SearchList.ItemsSource = _lectures;
        }

        private void FunctionSearch_OnSearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = FunctionSearch.Text;

            IEnumerable <string> searchOutput =_lectures.Where(lecture => lecture.ToLower().Contains(keyword.ToLower()));

            SearchList.ItemsSource = searchOutput;
        }
    }
}
