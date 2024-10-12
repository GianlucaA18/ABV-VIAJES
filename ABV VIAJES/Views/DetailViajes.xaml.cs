using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABV_VIAJES.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailViajes : ContentPage
    {
        public DetailViajes()
        {
            InitializeComponent();
        }
        public void SetMapLocation(string googleMapsLink)
        {
            mapWebView.Source = googleMapsLink; // Asigna el enlace de Google Maps
        }

        private async void OnRegresarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}