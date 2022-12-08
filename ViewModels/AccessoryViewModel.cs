using IE307.N11.Models;
using IE307.N11.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace IE307.N11.ViewModels
{
    public class AccessoryViewModel
    {
        public ObservableCollection<Item> Accessories { get; set; }
        public ObservableCollection<Item> Headphone { get; set; }
        public ObservableCollection<Item> Cable { get; set; }
        public AccessoryViewModel()
        {
            Init();
        }

        private void Init()
        {
            Accessories = new ObservableCollection<Item>();
            Headphone = new ObservableCollection<Item>();
            Cable = new ObservableCollection<Item>();
            foreach (Item Item in ItemDataStore.Items)
            {
                if (Item is Accessory)
                {
                    var accessory = Item as Accessory;
                    Accessories.Add(accessory);
                    if (accessory.Categories.Contains(Accessory.Category.HEADPHONE)) Headphone.Add(accessory);
                    if (accessory.Categories.Contains(Accessory.Category.CABLE)) Cable.Add(accessory);
                }
            }
        }

    }
}
