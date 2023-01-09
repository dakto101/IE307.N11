using IE307.N11.Views;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace IE307.N11
{
    public partial class AppShell : Xamarin.Forms.Shell
    {

        private const String HELP_1 = "Using AnkiDroid";
        private const String HELP_2 = "Get Help";
        private const String HELP_3 = "Community";

        private const String HELP_1_1 = "AnkiDroid Manual";
        private const String HELP_1_2 = "Anki Manual";
        private const String HELP_1_3 = "AnkiDroid FAQ";

        private const String HELP_2_1 = "Mailing List";
        private const String HELP_2_2 = "Report a Bug";
        private const String HELP_2_3 = "Send troubleshooting report";

        private const String HELP_3_1 = "Anki Forums";
        private const String HELP_3_2 = "Reddits";
        private const String HELP_3_3 = "Mailing List";
        private const String HELP_3_4 = "Discord";
        private const String HELP_3_5 = "Facebook";
        private const String HELP_3_6 = "Twitter";

        public AppShell()
        {
            InitializeComponent();
        }

        private void MenuItem_Settings_Clicked(object sender, EventArgs e)
        {
            // Den trang Settings
            Shell.Current.Navigation.PushAsync(new SettingsPage());
            //Browser.OpenAsync("https://aka.ms/xamarin-quickstart");
        }

        private async void MenuItem_Help_Clicked(object sender, EventArgs e)
        {
            
            string action1 = await DisplayActionSheet("Help", "Cancel", null, HELP_1, HELP_2, HELP_3);
            switch (action1)
            {
                case HELP_1:
                    {
                        string action2 = await DisplayActionSheet(HELP_1, "Cancel", null, HELP_1_1, HELP_1_2, HELP_1_3);
                    }
                    break;
                case HELP_2:
                    {
                        string action2 = await DisplayActionSheet(HELP_2, "Cancel", null, HELP_2_1, HELP_2_2, HELP_2_3);
                    }
                    break;
                case HELP_3:
                    {
                        string action2 = await DisplayActionSheet(HELP_3, "Cancel", null, HELP_3_1, HELP_3_2, HELP_3_3, HELP_3_4, HELP_3_5, HELP_3_6);
                    }
                    break;
                default:
                    break;
            }
        }
        private async void MenuItem_Support_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Support AnkiDroid", "Cancel", null, "Donate", "Translate", "Develop", "Rate", "Other", "Send feedback");
        }
    }
}
