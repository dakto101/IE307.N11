using IE307.N11.Models;
using IE307.N11.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace IE307.N11.Services
{
    public class SettingsService
    {

        public static readonly ObservableCollection<Setting> Settings = new ObservableCollection<Setting>();
        public static readonly ObservableCollection<Setting> Settings_AnkiDroid = new ObservableCollection<Setting>();
        public static readonly ObservableCollection<Setting> Settings_Reviewing = new ObservableCollection<Setting>();
        public static readonly ObservableCollection<Setting> Settings_Appearance = new ObservableCollection<Setting>();
        public static readonly ObservableCollection<Setting> Settings_Gestures = new ObservableCollection<Setting>();
        public static readonly ObservableCollection<Setting> Settings_Advanced = new ObservableCollection<Setting>();

        public SettingsService()
        {
            Init();
        }

        public static void Init()
        {
            // Settings Main Page
            Settings_Init();
            // Settings AnkiDroid
            Settings_Init_AnkiDroid();
            // Settings Reviewing
            Settings_Init_Reviewing();
            // Settings Appearance
            Settings_Init_Appearance();
            // Settings Gestures
            Settings_Init_Gestures();
            // Settings Advanced
            Settings_Init_Advanced();
        }

        private static void Settings_Init()
        {
            Settings.Add(new Setting
            {
                Id = "ankidroid",
                Name = "AnkiDroid",
                Description = "General settings",
                Command = new Command(o =>
                {
                    Shell.Current.Navigation.PushAsync(new SettingsPage_AnkiDroid());
                })
            });
            Settings.Add(new Setting
            {
                Id = "reviewing",
                Name = "Reviewing",
                Description = "Non-deck-specific reviewer settings",
                Command = new Command(o =>
                {
                    Shell.Current.Navigation.PushAsync(new SettingsPage_Reviewing());
                })
            });

            Settings.Add(new Setting
            {
                Id = "appearance",
                Name = "Appearance",
                Description = "Change themes and default font",
                Command = new Command(o =>
                {
                    Shell.Current.Navigation.PushAsync(new SettingsPage_Appearance());
                })
            });
            Settings.Add(new Setting
            {
                Id = "gestures",
                Name = "Gestures",
                Description = "Use taps and swipes instead of buttons",
                Command = new Command(o =>
                {
                    Shell.Current.Navigation.PushAsync(new SettingsPage_Gestures());
                })
            });
            Settings.Add(new Setting
            {
                Id = "advanced",
                Name = "Advanced",
                Description = "Optimization and experimental features",
                Command = new Command(o =>
                {
                    Shell.Current.Navigation.PushAsync(new SettingsPage_Advanced());
                })
            });
        }

        private static void Settings_Init_AnkiDroid()
        {
            Settings_AnkiDroid.Add(new Setting
            {
                Id = "ankidroid_account",
                Name = "AnkiWeb account",
                Value = false,
                Description = "",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Fetch media on sync",
                Description = "Automatically fetch missing media when syncing",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Automatic synchronization",
                Description = "Sync automatically on app start/exit if the last sync was more than 10 minutes ago.",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Display synchronization status",
                Description = "Change the sync icon when changes can be uploaded",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Deck for new cards",
                Description = "Decide by note type",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Language",
                Description = "System language",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Share feature usage",
                Description = "You can contribute to AnkiDroid by helping the development team see which features people use",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Error reporting mode",
                Description = "Ask me",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Notify when",
                Description = "Pending messages available",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Vibrate",
                Description = "",
                Command = new Command(o =>
                {
                })
            });
            Settings_AnkiDroid.Add(new Setting
            {
                Name = "Blink light",
                Description = "",
                Command = new Command(o =>
                {
                })
            });

        }

        private static void Settings_Init_Reviewing()
        {
            Settings_Reviewing.Add(new Setting
            {
                Name = "New card position",
                Description = "Mix new cards and reviews",
                Command = new Command(o =>
                {

                })
            });
            Settings_Reviewing.Add(new Setting
            {
                Name = "Start of next day",
                Description = "4 hours past midnight",
                Command = new Command(o =>
                {

                })
            });
            Settings_Reviewing.Add(new Setting
            {
                Name = "Learn ahead limit",
                Description = "20 min",
                Command = new Command(o =>
                {

                })
            });
            Settings_Reviewing.Add(new Setting
            {
                Name = "Timebox time limit",
                Description = "0 min",
                Command = new Command(o =>
                {

                })
            });
        }
        private static void Settings_Init_Appearance()
        {
            Settings_Appearance.Add(new Setting
            {
                Name = "Day theme",
                Description = "Light",
            });
            Settings_Appearance.Add(new Setting
            {
                Name = "Night theme",
                Description = "Black",
            });
            Settings_Appearance.Add(new Setting
            {
                Name = "Default font",
                Description = "System default",
            });
            Settings_Appearance.Add(new Setting
            {
                Name = "Default font applicability",
                Description = "When no font specified on flashcards",
            });
            Settings_Appearance.Add(new Setting
            {
                Name = "Browser and editor font",
                Description = "System default",
            });
            Settings_Appearance.Add(new Setting
            {
                Name = "Card browser font scaling",
                Description = "100%",
            });
            Settings_Appearance.Add(new Setting
            {
                Name = "Display filenames in card browser",
                Description = "Display media filenames in the card browser question/answer fields",
            });
        }
        private static void Settings_Init_Gestures()
        {
            Settings_Gestures.Add(new Setting
            {
                Name = "Enable gestures",
                Description = "Assign gestures to actions such as answering and editing cards."
            });
        }
        private static void Settings_Init_Advanced()
        {
            Settings_Advanced.Add(new Setting
            {
                Name = "AnkiDroid directory",
                Description = "/storage/emulated/0/AnkiDroid",
            });
            Settings_Advanced.Add(new Setting
            {
                Name = "Force full sync",
                Description = "On next sync, force changes in one direction",
            });
            Settings_Advanced.Add(new Setting
            {
                Name = "Custom sync server",
                Description = "Disabled",
            });
            Settings_Advanced.Add(new Setting
            {
                Name = "Max number of backups",
                Description = "8",
            });
            Settings_Advanced.Add(new Setting
            {
                Name = "About AnkiDroid",
                Description = "Version: 2.15.6",
            });
            Settings_Advanced.Add(new Setting
            {
                Name = "Open Changelog",
                Description = "",
            });
        }

        
        public static object GetValue(String id)
        {
            foreach (Setting setting in Settings) {
                if (setting.Id.Equals(id)) return setting.Value;
            }
            foreach (Setting setting in Settings_AnkiDroid)
            {
                if (setting.Id.Equals(id)) return setting.Value;
            }
            foreach (Setting setting in Settings_Reviewing)
            {
                if (setting.Id.Equals(id)) return setting.Value;
            }
            foreach (Setting setting in Settings_Appearance)
            {
                if (setting.Id.Equals(id)) return setting.Value;
            }
            foreach (Setting setting in Settings_Gestures)
            {
                if (setting.Id.Equals(id)) return setting.Value;
            }
            foreach (Setting setting in Settings_Advanced)
            {
                if (setting.Id.Equals(id)) return setting.Value;
            }
            return null;
        }

         
        public static void SetValue(String id, object value)
        {
            foreach (Setting setting in Settings)
            {
                if (setting.Id.Equals(id)) setting.Value = value;
            }
            foreach (Setting setting in Settings_AnkiDroid)
            {
                if (setting.Id.Equals(id)) setting.Value = value;
            }
            foreach (Setting setting in Settings_Reviewing)
            {
                if (setting.Id.Equals(id)) setting.Value = value;
            }
            foreach (Setting setting in Settings_Appearance)
            {
                if (setting.Id.Equals(id)) setting.Value = value;
            }
            foreach (Setting setting in Settings_Gestures)
            {
                if (setting.Id.Equals(id)) setting.Value = value;
            }
            foreach (Setting setting in Settings_Advanced)
            {
                if (setting.Id.Equals(id)) setting.Value = value;
            }

        }
    }
}
