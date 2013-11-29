using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DrinkSafe
{
    public partial class Main : PhoneApplicationPage
    {
        public Main()
        {
            InitializeComponent();
            //Grid grid = new Grid();
            //grid.Height = 100;
            //VservAdControl VMB = VservAdControl.Instance;
            //VMB.RenderAd("c3346f1c",grid);
        }

        private void nextButtonClick(object sender, RoutedEventArgs e)
        {
            string wt = weight.SelectedItem.ToString();
            string gndr = gender.SelectedItem.ToString();
            string tim = time.Value.ToString();
            //MessageBox.Show(tim);
            if (wt == "Select" || gndr == "Select")
            {
                MessageBox.Show("Enter the required fields");
            }
            else
            {
                var obj = App.Current as App;
                obj.wt = wt;
                obj.gndr = gndr;
                obj.tim = tim;
                NavigationService.Navigate(new Uri("/liq_list.xaml", UriKind.Relative));
            }
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}