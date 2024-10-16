﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ABV_VIAJES.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bares : ContentPage
    {
        public Bares()
        {
            InitializeComponent();
        }

        private async void OnBaresTapped(object sender, EventArgs e)
        {
            string googleMapsLink = "https://www.google.com/maps?q=40.7128,-74.0060"; // Sustituye esto por el enlace real de tu API
            await Navigation.PushAsync(new DetailBares(googleMapsLink));
        }
    }
}