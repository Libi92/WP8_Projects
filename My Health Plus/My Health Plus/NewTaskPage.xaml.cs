﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using My_Health_Plus.Model;
namespace My_Health_Plus
{
    public partial class NewTaskPage : PhoneApplicationPage
    {
        public NewTaskPage()
        {
            InitializeComponent();
            this.DataContext = App.ViewModel; 
        }
        private void appBarOkButton_Click(object sender, EventArgs e)
        {
            // Confirm there is some text in the text box.
            if (newTaskNameTextBox.Text.Length > 0)
            {
                // Create a new to-do item.
                ToDoItem newToDoItem = new ToDoItem
                {
                    ItemName = newTaskNameTextBox.Text,
                    Descrptn="sdsdsf",
                    Category = (ToDoCategory)categoriesListPicker.SelectedItem
                };

                // Add the item to the ViewModel.
                App.ViewModel.AddToDoItem(newToDoItem);

                // Return to the main page.
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
            }
        }

        private void appBarCancelButton_Click(object sender, EventArgs e)
        {
            // Return to the main page.
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}