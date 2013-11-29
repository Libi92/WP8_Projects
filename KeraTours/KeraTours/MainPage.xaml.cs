using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Nokia.Phone.HereLaunchers;
using System.Device.Location;
using vservWindowsPhone;

namespace KeraTours
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            btnFlipTile_Click(alap,e);
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void alapuzha(object sender, System.Windows.Input.GestureEventArgs e)
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

        private void wayanad(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                ExploremapsShowPlaceTask showPlace = new ExploremapsShowPlaceTask();
                showPlace.Location = new GeoCoordinate(11.6050, 76.0830);
                showPlace.Zoom = 13;
                showPlace.Title = "The Place";
                showPlace.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error: " + er.Message);
            }
        }

        private void bekal(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                ExploremapsShowPlaceTask showPlace = new ExploremapsShowPlaceTask();
                showPlace.Location = new GeoCoordinate(12.4000, 75.0500);
                showPlace.Zoom = 13;
                showPlace.Title = "The Place";
                showPlace.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error: " + er.Message);
            }
        }

        private void fort(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                ExploremapsShowPlaceTask showPlace = new ExploremapsShowPlaceTask();
                showPlace.Location = new GeoCoordinate(9.9680, 76.2440);
                showPlace.Zoom = 13;
                showPlace.Title = "The Place";
                showPlace.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error: " + er.Message);
            }
        }

        private void kumarakom(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                ExploremapsShowPlaceTask showPlace = new ExploremapsShowPlaceTask();
                showPlace.Location = new GeoCoordinate(9.60716, 76.41972);
                showPlace.Zoom = 13;
                showPlace.Title = "The Place";
                showPlace.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error: " + er.Message);
            }
        }

        private void munnar(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                ExploremapsShowPlaceTask showPlace = new ExploremapsShowPlaceTask();
                showPlace.Location = new GeoCoordinate(10.0892, 77.0597);
                showPlace.Zoom = 13;
                showPlace.Title = "The Place";
                showPlace.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error: " + er.Message);
            }
        }

        private void thekkady(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                ExploremapsShowPlaceTask showPlace = new ExploremapsShowPlaceTask();
                showPlace.Location = new GeoCoordinate(9.5330, 77.2000);
                showPlace.Zoom = 13;
                showPlace.Title = "The Place";
                showPlace.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error: " + er.Message);
            }
        }

        private void kerala(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                ExploremapsShowPlaceTask showPlace = new ExploremapsShowPlaceTask();
                showPlace.Location = new GeoCoordinate(8.5074, 76.9720);
                showPlace.Zoom = 8;
                showPlace.Title = "The Place";
                showPlace.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error: " + er.Message);
            }
        }


        private void btnFlipTile_Click(object sender, RoutedEventArgs e)
        {
            // find the tile object for the application tile that using "flip" contains string in it.
            ShellTile oTile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains("flip".ToString()));


            if (oTile != null && oTile.NavigationUri.ToString().Contains("flip"))
            {
                FlipTileData oFliptile = new FlipTileData();
                oFliptile.Title = "KeraTours";
                oFliptile.Count = 0;
                oFliptile.BackTitle = "Places to visit";

                oFliptile.BackContent = "Gods Own Country";
                oFliptile.WideBackContent = "Gods Own Country";

                oFliptile.SmallBackgroundImage = new Uri("Assets/Tiles/Flip/159x159.png", UriKind.Relative);
                oFliptile.BackgroundImage = new Uri("Assets/Tiles/Flip/336x336.png", UriKind.Relative);
                oFliptile.WideBackgroundImage = new Uri("Assets/Tiles/Flip/691x336.png", UriKind.Relative);

                oFliptile.BackBackgroundImage = new Uri("/Assets/Tiles/Flip/A336.png", UriKind.Relative);
                oFliptile.WideBackBackgroundImage = new Uri("/Assets/Tiles/Flip/A691.png", UriKind.Relative);
                oTile.Update(oFliptile);
                //MessageBox.Show("Flip Tile Data successfully update.");
            }
            else
            {
                // once it is created flip tile
                Uri tileUri = new Uri("/MainPage.xaml?tile=flip", UriKind.Relative);
                ShellTileData tileData = this.CreateFlipTileData();
                ShellTile.Create(tileUri, tileData, true);
            }
        }

        private ShellTileData CreateFlipTileData()
        {
            return new FlipTileData()
            {
                Title = "KeraTours",
                BackTitle = "Places to visit",
                BackContent = "God's Own Country",
                WideBackContent = "God's Own Country",
                Count = 8,
                SmallBackgroundImage = new Uri("/Assets/Tiles/Flip/A159.png", UriKind.Relative),
                BackgroundImage = new Uri("/Assets/Tiles/Flip/A336.png", UriKind.Relative),
                WideBackgroundImage = new Uri("/Assets/Tiles/Flip/A691.png", UriKind.Relative),
            };
        }

        public RoutedEventArgs e { get; set; }

        //private void Billboard_Click(object sender, RoutedEventArgs e)
        //{
        //    VservAdControl VMB = VservAdControl.Instance;
        //    VMB.SetRequestTimeOut(0);
        //    //This is for Showing Billboard AD
        //    VMB.DisplayAd("b4335f8a", LayoutRoot);
        //}

        
    }
}