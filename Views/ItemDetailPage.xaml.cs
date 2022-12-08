using IE307.N11.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IE307.N11.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}