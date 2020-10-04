using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace emredeisgn.ViewModels
{
    public class DetailViewModel
    {
        public Command BackCmd { get; set; }

        public DetailViewModel()
        {
            BackCmd = new Command(backMtd);
        }

        private void backMtd(object obj)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
