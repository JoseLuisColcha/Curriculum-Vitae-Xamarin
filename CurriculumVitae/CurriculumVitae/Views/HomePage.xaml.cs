using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurriculumVitae.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnStart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListCVPAge());
        }
    }
}