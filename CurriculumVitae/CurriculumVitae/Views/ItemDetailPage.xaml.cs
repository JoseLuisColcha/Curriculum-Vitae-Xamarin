using CurriculumVitae.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CurriculumVitae.Views
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