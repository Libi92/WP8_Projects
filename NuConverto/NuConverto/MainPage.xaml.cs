using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NuConverto.Resources;

namespace NuConverto
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void tbmtr_chngd(object sender, TextChangedEventArgs e)
        {
            if (tbmtr.Text == "")
            {
                tbmtr.Text = "";
                tbkmtr.Text = "";
                tbyrd.Text = "";
                tbmyl.Text = "";
                tbin.Text = "";
                tbft.Text = "";
                tbnm.Text = "";
                tbflg.Text = "";
            }
            else
            {
                double m = Convert.ToDouble(tbmtr.Text);
                double km = m / 1000;
                double yd = m * 1.09361;
                double mile = m * 0.000621371;
                double inch = m * 39.3701;
                double foot = m * 3.28084;
                double nautm = m * 0.000539957;
                double frlng = m * 0.00497096954;

                tbkmtr.Text = km.ToString();
                tbyrd.Text = yd.ToString();
                tbmyl.Text = mile.ToString();
                tbin.Text = inch.ToString();
                tbft.Text = foot.ToString();
                tbnm.Text = nautm.ToString();
                tbflg.Text = frlng.ToString();
            }
        }

        private void tbkmtr_chngd(object sender, TextChangedEventArgs e)
        {
            
            try
            {
                if (tbkmtr.Text == "")
                {
                    tbmtr.Text = "";
                    tbkmtr.Text = "";
                    tbyrd.Text = "";
                    tbmyl.Text = "";
                    tbin.Text = "";
                    tbft.Text = "";
                    tbnm.Text = "";
                    tbflg.Text = "";
                }
                
                else
                {
                    double km = Convert.ToDouble(tbkmtr.Text);
                    double m = km * 1000;
                    double yd = m * 1.09361;
                    double mile = m * 0.000621371;
                    double inch = m * 39.3701;
                    double foot = m * 3.28084;
                    double nautm = m * 0.000539957;
                    double frlng = m * 0.00497096954;

                    tbmtr.DataContext = m;
                    tbyrd.DataContext = yd;
                    tbmyl.DataContext = mile;
                    tbin.DataContext = inch;
                    tbft.DataContext = foot;
                    tbnm.DataContext = nautm;

                    tbflg.Text = frlng.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void tbyrd_chngd(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (tbyrd.Text == "")
                {
                    tbmtr.Text = "";
                    tbkmtr.Text = "";
                    tbyrd.Text = "";
                    tbmyl.Text = "";
                    tbin.Text = "";
                    tbft.Text = "";
                    tbnm.Text = "";
                    tbflg.Text = "";
                }
                else
                {
                    double yd = Convert.ToDouble(tbyrd.Text);
                    yd = Math.Round(yd, 2);
                    double m = yd * 0.9144;
                    m = Math.Round(m, 2);
                    double km = m / 1000;
                    double mile = m * 0.000621371;
                    double inch = m * 39.3701;
                    double foot = m * 3.28084;
                    double nautm = m * 0.000539957;
                    double frlng = m * 0.00497096954;
                    txtyrd.Text = inch.ToString();
                    tbmtr.Text = m.ToString();
                    //tbkmtr.Text = km.ToString();
                    //tbmyl.Text = mile.ToString();
                    //tbin.Text = inch.ToString();
                    //tbft.Text = foot.ToString();
                    //tbnm.Text = nautm.ToString();
                    //tbflg.Text = frlng.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void tbmyl_chngd(object sender, TextChangedEventArgs e)
        {
            if (tbmyl.Text == "")
            {
                tbmtr.Text = "";
                tbkmtr.Text = "";
                tbyrd.Text = "";
                tbmyl.Text = "";
                tbin.Text = "";
                tbft.Text = "";
                tbnm.Text = "";
                tbflg.Text = "";
            }
            else
            {
                double mile = Convert.ToDouble(tbmyl.Text);
                double m = mile / 0.000621371;
                double km = m / 1000;
                double yd = m * 1.09361;
                double inch = m * 39.3701;
                double foot = m * 3.28084;
                double nautm = m * 0.000539957;
                double frlng = m * 0.00497096954;

                tbmtr.Text = m.ToString();
                tbkmtr.Text = km.ToString();
                tbmyl.Text = mile.ToString();
                tbin.Text = inch.ToString();
                tbft.Text = foot.ToString();
                tbnm.Text = nautm.ToString();
                tbflg.Text = frlng.ToString();
            }
        }

        private void tbin_chngd(object sender, TextChangedEventArgs e)
        {
            if (tbin.Text == "")
            {
                tbmtr.Text = "";
                tbkmtr.Text = "";
                tbyrd.Text = "";
                tbmyl.Text = "";
                tbin.Text = "";
                tbft.Text = "";
                tbnm.Text = "";
                tbflg.Text = "";
            }
            else
            {
                double inch = Convert.ToDouble(tbin.Text);
                double m = inch / 39.3701;
                double km = m / 1000;
                double yd = m * 1.09361;
                double mile = m * 0.000621371;
                double foot = m * 3.28084;
                double nautm = m * 0.000539957;
                double frlng = m * 0.00497096954;

                tbmtr.Text = m.ToString();
                tbkmtr.Text = km.ToString();
                tbmyl.Text = mile.ToString();
                tbin.Text = inch.ToString();
                tbft.Text = foot.ToString();
                tbnm.Text = nautm.ToString();
                tbflg.Text = frlng.ToString();
            }
        }

        private void tbft_chngd(object sender, TextChangedEventArgs e)
        {
            if (tbft.Text == "")
            {
                tbmtr.Text = "";
                tbkmtr.Text = "";
                tbyrd.Text = "";
                tbmyl.Text = "";
                tbin.Text = "";
                tbft.Text = "";
                tbnm.Text = "";
                tbflg.Text = "";
            }
            else
            {
                double foot = Convert.ToDouble(tbft.Text);
                double m = foot / 3.28084;
                double km = m / 1000;
                double yd = m * 1.09361;
                double mile = m * 0.000621371;
                double inch = m * 39.3701;
                double nautm = m * 0.000539957;
                double frlng = m * 0.00497096954;

                tbmtr.Text = m.ToString();
                tbkmtr.Text = km.ToString();
                tbmyl.Text = mile.ToString();
                tbin.Text = inch.ToString();
                tbft.Text = foot.ToString();
                tbnm.Text = nautm.ToString();
                tbflg.Text = frlng.ToString();
            }
        }

        private void tbnm_chngd(object sender, TextChangedEventArgs e)
        {
            if (tbnm.Text == "")
            {
                tbmtr.Text = "";
                tbkmtr.Text = "";
                tbyrd.Text = "";
                tbmyl.Text = "";
                tbin.Text = "";
                tbft.Text = "";
                tbnm.Text = "";
                tbflg.Text = "";
            }
            else
            {
                double nautm = Convert.ToDouble(tbnm.Text);
                double m = nautm / 0.000539957;
                double km = m / 1000;
                double yd = m * 1.09361;
                double mile = m * 0.000621371;
                double inch = m * 39.3701;
                double foot = m * 3.28084;
                double frlng = m * 0.00497096954;

                tbmtr.Text = m.ToString();
                tbkmtr.Text = km.ToString();
                tbmyl.Text = mile.ToString();
                tbin.Text = inch.ToString();
                tbft.Text = foot.ToString();
                tbnm.Text = nautm.ToString();
                tbflg.Text = frlng.ToString();
            }
        }

        private void tbflg_chngd(object sender, TextChangedEventArgs e)
        {
            if (tbflg.Text == "")
            {
                tbmtr.Text = "";
                tbkmtr.Text = "";
                tbyrd.Text = "";
                tbmyl.Text = "";
                tbin.Text = "";
                tbft.Text = "";
                tbnm.Text = "";
                tbflg.Text = "";
            }
            else
            {
                double frlng = Convert.ToDouble(tbflg.Text);
                double m = frlng / 0.00497096954;
                double km = m / 1000;
                double yd = m * 1.09361;
                double mile = m * 0.000621371;
                double inch = m * 39.3701;
                double foot = m * 3.28084;
                double nautm = m * 0.000539957;

                tbmtr.Text = m.ToString();
                tbkmtr.Text = km.ToString();
                tbmyl.Text = mile.ToString();
                tbin.Text = inch.ToString();
                tbft.Text = foot.ToString();
                tbnm.Text = nautm.ToString();
                tbflg.Text = frlng.ToString();
            }
        }
        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}