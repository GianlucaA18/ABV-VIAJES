using ABV_VIAJES.Model;
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
    public partial class DetailHoteles : ContentPage
    {
        public DetailHoteles(string googleMapsLink)
        {
            InitializeComponent();
            mapWebView.Source = googleMapsLink;
        }
    }
}