﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ABV_VIAJES.Views;

namespace ABV_VIAJES
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Master=new Master();
            this.Detail = new NavigationPage(new Detail());
            App.MasterDet = this;
        }
    }
}
