using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace emredeisgn.ViewModels
{
    public class StartViewModel
    {
        public Command gotoShell { get; set; }
        public StartViewModel()
        {
            gotoShell = new Command(gotoNav);
        }

        private void gotoNav(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}
