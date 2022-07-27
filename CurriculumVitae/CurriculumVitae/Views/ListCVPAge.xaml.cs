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
                "José luis Colcha",
                "Name 2",
                "Name 3",
                "Name 4"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new PersonalInformationPage());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
