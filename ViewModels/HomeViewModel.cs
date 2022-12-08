using IE307.N11.Models;
using IE307.N11.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace IE307.N11.ViewModels
{
    public class HomeViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public HomeViewModel()
        {
            Items = ItemDataStore.Items;
        }

    }
}
