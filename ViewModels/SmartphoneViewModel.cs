using IE307.N11.Models;
using IE307.N11.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace IE307.N11.ViewModels
{
    public class SmartphoneViewModel
    {
        public ObservableCollection<Item> Smartphones { get; set; }
        public ObservableCollection<Item> IOS { get; set; }
        public ObservableCollection<Item> Android { get; set; }
        public SmartphoneViewModel()
        {
            Init();
        }

        private void Init()
        {
            Smartphones = new ObservableCollection<Item>();
            IOS = new ObservableCollection<Item>();
            Android = new ObservableCollection<Item>();
            foreach (Item Item in ItemDataStore.Items)
            {
                if (Item is Smartphone)
                {
                    var Smartphone = Item as Smartphone;
                    Smartphones.Add(Smartphone);
                    if (Smartphone.Categories.Contains(Smartphone.Category.IOS)) IOS.Add(Smartphone);
                    if (Smartphone.Categories.Contains(Smartphone.Category.ANDROID)) Android.Add(Smartphone);
                }
            }
        }

    }
}
