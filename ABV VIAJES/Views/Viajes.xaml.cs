using ABV_VIAJES.Model;
using ABV_VIAJES.ModelView;
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
    public partial class Viajes : ContentPage
    {
        public Viajes()
        {
            InitializeComponent();
        }

        private async void OnLugarTapped(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                var lugarSeleccionado = e.CurrentSelection.FirstOrDefault() as Viaje;

                if (lugarSeleccionado != null)
                {
                    var detailPage = new DetailViajes
                    {
                        BindingContext = lugarSeleccionado // Asigna el lugar seleccionado como contexto de datos
                    };

                    // Establece la URL del WebView con el enlace de Google Maps
                    detailPage.SetMapLocation(lugarSeleccionado.GoogleMapsLink);

                    await Navigation.PushAsync(detailPage);
                }
            }
        }
    }
}