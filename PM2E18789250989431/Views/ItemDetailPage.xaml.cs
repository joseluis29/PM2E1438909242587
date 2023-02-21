using PM2E18789250989431.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PM2E18789250989431.Views
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