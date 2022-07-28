using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurriculumVitae.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCVPAge : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListCVPAge()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "José Luis Colcha",
                "Wendy Palomo"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            if(e.Item.Equals("José Luis Colcha"))
            {
                await Navigation.PushAsync(new PersonalInformationPage());
            }
            else
            {
                await Navigation.PushAsync(new PersonalInformationPage2());
            }
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
