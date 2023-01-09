using IE307.N11.Models;
using IE307.N11.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IE307.N11.ViewModels
{
   public  class SettingsViewModel
    {

        public ObservableCollection<Setting> Settings { get; set; }
        public ObservableCollection<Setting> Settings_AnkiDroid { get; set; }
        public ObservableCollection<Setting> Settings_Reviewing { get; set; }
        public ObservableCollection<Setting> Settings_Appearance { get; set; }
        public ObservableCollection<Setting> Settings_Gestures { get; set; }
        public ObservableCollection<Setting> Settings_Advanced { get; set; }
        public SettingsViewModel()
        {
            Settings = SettingsService.Settings;
            Settings_AnkiDroid = SettingsService.Settings_AnkiDroid;
            Settings_Reviewing = SettingsService.Settings_Reviewing;
            Settings_Appearance = SettingsService.Settings_Appearance;
            Settings_Gestures = SettingsService.Settings_Gestures;
            Settings_Advanced = SettingsService.Settings_Advanced;
        }

    }
}
