﻿using System;
using System.Windows.Controls;
using EVEMarket.WPF.Interfaces;

namespace EVEMarket.WPF
{
    /// <summary>
    /// Interaction logic for MarketDetails.xaml
    /// </summary>
    public partial class MarketDetails : Page
    {
        public MarketDetails()
        {
            InitializeComponent();
        }

        protected override async void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            this.IsEnabled = false;

            var vm = this.DataContext as VmWithInitialization;
            await vm.InitializeAsync();

            this.IsEnabled = true;
        }
    }
}