using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace emredeisgn.Views
{
    public class ListViewModel
    {
        public Command navToDetail { get; set; }
        public ListViewModel()
        {
            navToDetail = new Command(detailPage);
        }

        private void detailPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new DetailPage());
        }
    }
}
