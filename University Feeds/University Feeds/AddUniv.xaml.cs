using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace University_Feeds
{
    public partial class Page2 : PhoneApplicationPage
    {
        static Int16 i = 0;
        string[] depts=new string[10];
        public Page2()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
            TextBox myText = new TextBox();
            myText.Width = 364;
            //myText.Text = "Dynamically added control";
            root.Children.Add(myText);
            depts[i++] = myText.Text;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}