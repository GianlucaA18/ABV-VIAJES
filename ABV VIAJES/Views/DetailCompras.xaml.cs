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
    public partial class DetailCompras : ContentPage
    {
        public DetailCompras(string googleMapsLink)
        {
            InitializeComponent();
            mapWebView.Source = googleMapsLink;
        }

        private async void OnRegresarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}