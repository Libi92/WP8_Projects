using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Lex.Db;
using LexDb.Entities;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LexDb.Resources;

namespace LexDb
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            DataContext = App.ViewModel;
            LoadDatabase();
        }

        private DbInstance db;

        private async void LoadDatabase()
        {
            db = new DbInstance("catalog");
            db.Map<Activity>()
              .Automap(x => x.Id)
              .WithIndex("Title", x => x.Title);

            await db.InitializeAsync();
        }

        private async void OnInsertDataClicked(object sender, RoutedEventArgs e)
        {

            Activity activity = new Activity
                                    {
                                        Id = Convert.ToInt16(tbId.Text),
                                        Title = tbName.Text,
                                        Description = tbDesc.Text,
                                        ExpireDate = DateTime.Now.AddDays(3)
                                    };

            await db.Table<Activity>().SaveAsync(activity);
        }

        private async void OnReadDataClicked(object sender, RoutedEventArgs e)
        {
            Activity[] activities = await db.Table<Activity>().LoadAllAsync();

            foreach (var activity in activities)
            {
                MessageBox.Show(activity.Title);
            }
        }

        private async void OnReadSingleDataClicked(object sender, RoutedEventArgs e)
        {

            List<Activity> activities = await db.Table<Activity>().LoadAllAsync("Title", tbName.Text);

            foreach (var activity in activities)
            {
                MessageBox.Show(activity.Description);
            }
        }
    }
}