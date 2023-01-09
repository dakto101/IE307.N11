using IE307.N11.Services;
using IE307.N11.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IE307.N11.ViewModels
{
    public class DecksViewModel
    {
        public ObservableCollection<String> Items { get; set; }
        public ICommand Cmd_Sync { get; set; }
        public DecksViewModel()
        {
            Items = DataSample.Sample;
            Cmd_Sync = new Command(async o =>
            {
                if (SettingsService.GetValue("ankidroid_account").Equals(true))
                {
                    await Shell.Current.Navigation.PushAsync(new LoginPage_Logout());
                }
                else
                {
                    bool confirm = await App.Current.MainPage.DisplayAlert("Log in to AnkiWeb", "You must log in to a third party account " +
                        "to use the cloud sync service. You can create one in the next step.", "LOG IN", "CANCEL");
                    if (confirm)
                    {
                        await Shell.Current.Navigation.PushAsync(new LoginPage());
                    }
                }
            });
        }

    }
}
