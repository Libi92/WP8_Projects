using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Net.Browser;
using System.Diagnostics;

namespace University_Feeds
{
    public partial class returnMenu : PhoneApplicationPage
    {
        public returnMenu()
        {
            InitializeComponent();
        }
        
        private void btnGo(object sender, RoutedEventArgs e)
        {
            var client = new WebClient();

            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(loadHTMLCallback);
            client.DownloadStringAsync(new Uri("http://www.catonmat.net/download/awk.cheat.sheet.txt"));

        }
        public void loadHTMLCallback(Object sender, DownloadStringCompletedEventArgs e)
        {
            var textData = (string)e.Result;
            // Do cool stuff with result
            Debug.WriteLine(textData);
        }
        
    }
}