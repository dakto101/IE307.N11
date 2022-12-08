using IE307.N11.Services;
using System;
using Xamarin.Essentials;

namespace IE307.N11
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void MenuItem_About_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://aka.ms/xamarin-quickstart");
        }
    }
}
