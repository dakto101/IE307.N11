using IE307.N11.Models;
using IE307.N11.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace IE307.N11.ViewModels
{
    public class LaptopViewModel
    {
        public ObservableCollection<Item> Laptops { get; set; }
        public ObservableCollection<Item> LaptopsGaming { get; set; }
        public ObservableCollection<Item> LaptopsVanPhong { get; set; }
        public ObservableCollection<Item> LaptopsMac { get; set; }
        public LaptopViewModel()
        {
            Init();
        }

        private void Init()
        {
            Laptops = new ObservableCollection<Item>();
            LaptopsGaming = new ObservableCollection<Item>();
            LaptopsVanPhong = new ObservableCollection<Item>();
            LaptopsMac = new ObservableCollection<Item>();
            foreach (Item Item in ItemDataStore.Items)
            {
                if (Item is Laptop)
                {
                    var Laptop = Item as Laptop;
                    Laptops.Add(Laptop);
                    if (Laptop.Categories.Contains(Laptop.Category.GAMING)) LaptopsGaming.Add(Laptop);
                    if (Laptop.Categories.Contains(Laptop.Category.MACBOOK)) LaptopsMac.Add(Laptop);
                    if (Laptop.Categories.Contains(Laptop.Category.VAN_PHONG)) LaptopsVanPhong.Add(Laptop);
                }
            }
        }

    }
}
