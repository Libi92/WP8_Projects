using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Nokia.Phone.HereLaunchers;
using System.Device.Location;

namespace KeraTours
{
    public partial class alapuzha : PhoneApplicationPage
    {
        public alapuzha()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        

        private void map(object sender, RoutedEventArgs e)
        {
            try
            {
                ExploremapsShowPlaceTask showPlace = new ExploremapsShowPlaceTask();
                showPlace.Location = new GeoCoordinate(9.4900, 76.3300);
                showPlace.Zoom = 13;
                showPlace.Title = "The Place";
                showPlace.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error: " + er.Message);
            }
        }

        private void route(object sender, RoutedEventArgs e)
        {
            try
            {
                DirectionsRouteDestinationTask routeTo = new DirectionsRouteDestinationTask();

                routeTo.Destination = new GeoCoordinate(9.4900, 76.3300);
                routeTo.Mode = RouteMode.Car;
                routeTo.Show();
            }
            catch (Exception erno)
            {
                MessageBox.Show("Error message: " + erno.Message);
            }
        }
    }
}