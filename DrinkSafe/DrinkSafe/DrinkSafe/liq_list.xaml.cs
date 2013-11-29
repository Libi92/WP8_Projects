using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Globalization;

namespace DrinkSafe
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
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

        

        private void Pilsner_ch_checked(object sender, RoutedEventArgs e)
        {
            Pilsner_tb.Visibility = System.Windows.Visibility.Visible;
            Pilsner_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Pilsner_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Pilsner_tb.Visibility = System.Windows.Visibility.Collapsed;
            Pilsner_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void ESB_ch_checked(object sender, RoutedEventArgs e)
        {
            ESB_tb.Visibility = System.Windows.Visibility.Visible;
            ESB_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void ESB_ch_unchecked(object sender, RoutedEventArgs e)
        {
            ESB_tb.Visibility = System.Windows.Visibility.Collapsed;
            ESB_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Lager_ch_checked(object sender, RoutedEventArgs e)
        {
            Lager_tb.Visibility = System.Windows.Visibility.Visible;
            Lager_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Lager_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Lager_tb.Visibility = System.Windows.Visibility.Collapsed;
            Lager_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Porter_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Porter_tb.Visibility = System.Windows.Visibility.Collapsed;
            Porter_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Porter_ch_checked(object sender, RoutedEventArgs e)
        {
            Porter_tb.Visibility = System.Windows.Visibility.Visible;
            Porter_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void BrownAle_ch_checked(object sender, RoutedEventArgs e)
        {
            BrownAle_tb.Visibility = System.Windows.Visibility.Visible;
            BrownAle_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void BrownAle_ch_unchecked(object sender, RoutedEventArgs e)
        {
            BrownAle_tb.Visibility = System.Windows.Visibility.Collapsed;
            BrownAle_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void IPA_ch_checked(object sender, RoutedEventArgs e)
        {
            IPA_tb.Visibility = System.Windows.Visibility.Visible;
            IPA_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void IPA_ch_unchecked(object sender, RoutedEventArgs e)
        {
            IPA_tb.Visibility = System.Windows.Visibility.Collapsed;
            IPA_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Stout_ch_checked(object sender, RoutedEventArgs e)
        {
            Stout_tb.Visibility = System.Windows.Visibility.Visible;
            Stout_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Stout_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Stout_tb.Visibility = System.Windows.Visibility.Collapsed;
            Stout_t.Visibility = System.Windows.Visibility.Collapsed;
        }




        private void Sparkling_ch_checked(object sender, RoutedEventArgs e)
        {
            Sparkling_tb.Visibility = System.Windows.Visibility.Visible;
            Sparkling_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Sparkling_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Sparkling_tb.Visibility = System.Windows.Visibility.Collapsed;
            Sparkling_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Table_ch_checked(object sender, RoutedEventArgs e)
        {
            Table_tb.Visibility = System.Windows.Visibility.Visible;
            Table_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Table_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Table_tb.Visibility = System.Windows.Visibility.Collapsed;
            Table_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Retsina_ch_checked(object sender, RoutedEventArgs e)
        {
            Retsina_tb.Visibility = System.Windows.Visibility.Visible;
            Retsina_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Retsina_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Retsina_tb.Visibility = System.Windows.Visibility.Collapsed;
            Retsina_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void White_ch_unchecked(object sender, RoutedEventArgs e)
        {
            White_tb.Visibility = System.Windows.Visibility.Collapsed;
            White_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void White_ch_checked(object sender, RoutedEventArgs e)
        {
            White_tb.Visibility = System.Windows.Visibility.Visible;
            White_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Cabernet_ch_checked(object sender, RoutedEventArgs e)
        {
            Cabernet_tb.Visibility = System.Windows.Visibility.Visible;
            Cabernet_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Cabernet_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Cabernet_tb.Visibility = System.Windows.Visibility.Collapsed;
            Cabernet_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Barley_tb_checked(object sender, RoutedEventArgs e)
        {
            Barley_tb.Visibility = System.Windows.Visibility.Visible;
            Barley_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Barley_tb_unchecked(object sender, RoutedEventArgs e)
        {
            Barley_tb.Visibility = System.Windows.Visibility.Collapsed;
            Barley_t.Visibility = System.Windows.Visibility.Collapsed;
        }





        private void Sherry_ch_checked(object sender, RoutedEventArgs e)
        {
            Sherry_tb.Visibility = System.Windows.Visibility.Visible;
            Sherry_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Sherry_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Sherry_tb.Visibility = System.Windows.Visibility.Collapsed;
            Sherry_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Marsala_ch_checked(object sender, RoutedEventArgs e)
        {
            Marsala_tb.Visibility = System.Windows.Visibility.Visible;
            Marsala_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Marsala_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Marsala_tb.Visibility = System.Windows.Visibility.Collapsed;
            Marsala_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Madeira_ch_checked(object sender, RoutedEventArgs e)
        {
            Madeira_tb.Visibility = System.Windows.Visibility.Visible;
            Madeira_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Madeira_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Madeira_tb.Visibility = System.Windows.Visibility.Collapsed;
            Madeira_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Vermouth_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Vermouth_tb.Visibility = System.Windows.Visibility.Collapsed;
            Vermouth_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Vermouth_ch_checked(object sender, RoutedEventArgs e)
        {
            Vermouth_tb.Visibility = System.Windows.Visibility.Visible;
            Vermouth_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Port_ch_checked(object sender, RoutedEventArgs e)
        {
            Port_tb.Visibility = System.Windows.Visibility.Visible;
            Port_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Port_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Port_tb.Visibility = System.Windows.Visibility.Collapsed;
            Port_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Bum_ch_checked(object sender, RoutedEventArgs e)
        {
            Bum_tb.Visibility = System.Windows.Visibility.Visible;
            Bum_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Bum_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Bum_tb.Visibility = System.Windows.Visibility.Collapsed;
            Bum_t.Visibility = System.Windows.Visibility.Collapsed;
        }




        private void Light_ch_checked(object sender, RoutedEventArgs e)
        {
            Light_tb.Visibility = System.Windows.Visibility.Visible;
            Light_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Light_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Light_tb.Visibility = System.Windows.Visibility.Collapsed;
            Light_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Whisky_ch_checked(object sender, RoutedEventArgs e)
        {
            Whisky_tb.Visibility = System.Windows.Visibility.Visible;
            Whisky_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Whisky_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Whisky_tb.Visibility = System.Windows.Visibility.Collapsed;
            Whisky_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Cask_ch_checked(object sender, RoutedEventArgs e)
        {
            Cask_tb.Visibility = System.Windows.Visibility.Visible;
            Cask_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Cask_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Cask_tb.Visibility = System.Windows.Visibility.Collapsed;
            Cask_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Absinthe_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Absinthe_tb.Visibility = System.Windows.Visibility.Collapsed;
            Absinthe_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Absinthe_ch_checked(object sender, RoutedEventArgs e)
        {
            Absinthe_tb.Visibility = System.Windows.Visibility.Visible;
            Absinthe_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Grain_ch_checked(object sender, RoutedEventArgs e)
        {
            Grain_tb.Visibility = System.Windows.Visibility.Visible;
            Grain_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Grain_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Grain_tb.Visibility = System.Windows.Visibility.Collapsed;
            Grain_t.Visibility = System.Windows.Visibility.Collapsed;
        }





        private void Juice_ch_checked(object sender, RoutedEventArgs e)
        {
            Juice_tb.Visibility = System.Windows.Visibility.Visible;
            Juice_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Juice_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Juice_tb.Visibility = System.Windows.Visibility.Collapsed;
            Juice_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Alcopops_ch_checked(object sender, RoutedEventArgs e)
        {
            Alcopops_tb.Visibility = System.Windows.Visibility.Visible;
            Alcopops_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Alcopops_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Alcopops_tb.Visibility = System.Windows.Visibility.Collapsed;
            Alcopops_t.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void Breezers_ch_checked(object sender, RoutedEventArgs e)
        {
            Breezers_tb.Visibility = System.Windows.Visibility.Visible;
            Breezers_t.Visibility = System.Windows.Visibility.Visible;
        }

        private void Breezers_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Breezers_tb.Visibility = System.Windows.Visibility.Collapsed;
            Breezers_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Cider_ch_unchecked(object sender, RoutedEventArgs e)
        {
            Cider_tb.Visibility = System.Windows.Visibility.Collapsed;
            Cider_t.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Cider_ch_checked(object sender, RoutedEventArgs e)
        {
            Cider_tb.Visibility = System.Windows.Visibility.Visible;
            Cider_t.Visibility = System.Windows.Visibility.Visible;
        }





        private void calc_button_click(object sender, RoutedEventArgs e)
        {
            double alc = 0;
            var obj = App.Current as App;
            //MessageBox.Show(obj.wt+obj.gndr+obj.tim);
            if (Convert.ToBoolean(Pilsner_ch.IsChecked))
            {                
                if (Pilsner_tb.Text == "")
                    MessageBox.Show("Enter the amount of Pilsner you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Pilsner_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (3 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(ESB_ch.IsChecked))
            {
                if (ESB_tb.Text == "")
                    MessageBox.Show("Enter the amount of ESB you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(ESB_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (4 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Lager_ch.IsChecked))
            {
                if (Lager_tb.Text == "")
                    MessageBox.Show("Enter the amount of Lager you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Lager_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (5 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Porter_ch.IsChecked))
            {
                if (Porter_tb.Text == "")
                    MessageBox.Show("Enter the amount of Porter you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Porter_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (5 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(BrownAle_ch.IsChecked))
            {
                if (BrownAle_tb.Text == "")
                    MessageBox.Show("Enter the amount of BrownAle you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(BrownAle_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (6 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(IPA_ch.IsChecked))
            {
                if (IPA_tb.Text == "")
                    MessageBox.Show("Enter the amount of IPA you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(IPA_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (7 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Stout_ch.IsChecked))
            {
                if (Stout_tb.Text == "")
                    MessageBox.Show("Enter the amount of Stout you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Stout_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (9 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }


   ////////////////////////////////////////////////////////////////////////////


            if (Convert.ToBoolean(Sparkling_ch.IsChecked))
            {
                if (Sparkling_tb.Text == "")
                    MessageBox.Show("Enter the amount of Sparkling you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Sparkling_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (9 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Table_ch.IsChecked))
            {
                if (Table_tb.Text == "")
                    MessageBox.Show("Enter the amount of Table Wine you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Table_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (10 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Retsina_ch.IsChecked))
            {
                if (Retsina_tb.Text == "")
                    MessageBox.Show("Enter the amount of Retsina you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Retsina_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (11 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(White_ch.IsChecked))
            {
                if (White_tb.Text == "")
                    MessageBox.Show("Enter the amount of Dry White you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(White_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (12 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Cabernet_ch.IsChecked))
            {
                if (Cabernet_tb.Text == "")
                    MessageBox.Show("Enter the amount of Cabernet you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Cabernet_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (13 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Barley_ch.IsChecked))
            {
                if (Barley_tb.Text == "")
                    MessageBox.Show("Enter the amount of Barley you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Barley_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (7 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }


    ///////////////////////////////////////////////////////////////////////////////////////////


            if (Convert.ToBoolean(Sherry_ch.IsChecked))
            {
                if (Sherry_tb.Text == "")
                    MessageBox.Show("Enter the amount of Sherry you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Sherry_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (18 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Marsala_ch.IsChecked))
            {
                if (Marsala_tb.Text == "")
                    MessageBox.Show("Enter the amount of Marsala you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Marsala_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (17 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Madeira_ch.IsChecked))
            {
                if (Madeira_tb.Text == "")
                    MessageBox.Show("Enter the amount of Madeira you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Madeira_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (16 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Vermouth_ch.IsChecked))
            {
                if (Vermouth_tb.Text == "")
                    MessageBox.Show("Enter the amount of Vermouth you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Vermouth_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (16 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Port_ch.IsChecked))
            {
                if (Port_tb.Text == "")
                    MessageBox.Show("Enter the amount of Port Wine you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Port_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (19 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Bum_ch.IsChecked))
            {
                if (Bum_tb.Text == "")
                    MessageBox.Show("Enter the amount of Bum Wine you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Bum_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (19 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }


    ////////////////////////////////////////////////////////////////////////////////

            if (Convert.ToBoolean(Light_ch.IsChecked))
            {
                if (Light_tb.Text == "")
                    MessageBox.Show("Enter the amount of Light Liqueur you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Light_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (25 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Whisky_ch.IsChecked))
            {
                if (Whisky_tb.Text == "")
                    MessageBox.Show("Enter the amount of Vodka/Whiskey/Rum you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Whisky_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (40 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Cask_ch.IsChecked))
            {
                if (Cask_tb.Text == "")
                    MessageBox.Show("Enter the amount of Cask Strength Whiskey you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Cask_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (60 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Absinthe_ch.IsChecked))
            {
                if (Absinthe_tb.Text == "")
                    MessageBox.Show("Enter the amount of Absinthe you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Absinthe_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (75 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Grain_ch.IsChecked))
            {
                if (Grain_tb.Text == "")
                    MessageBox.Show("Enter the amount of Neutral Grain Spirit you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Grain_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (95 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }

        /////////////////////////////////////////////////////////////////////////////////////

            if (Convert.ToBoolean(Juice_ch.IsChecked))
            {
                if (Juice_tb.Text == "")
                    MessageBox.Show("Enter the amount of Juice you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Juice_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (0.01 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Alcopops_ch.IsChecked))
            {
                if (Alcopops_tb.Text == "")
                    MessageBox.Show("Enter the amount of Alcopops you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Alcopops_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (3 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Breezer_ch.IsChecked))
            {
                if (Breezers_tb.Text == "")
                    MessageBox.Show("Enter the amount of Wine Breezers/Coolers you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Breezers_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (4 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }
            if (Convert.ToBoolean(Cider_ch.IsChecked))
            {
                if (Cider_tb.Text == "")
                    MessageBox.Show("Enter the amount of Cider you had");
                else
                {
                    double contnt;
                    double wght;
                    double gdcons;
                    double stdrk = Convert.ToDouble(Cider_tb.Text);
                    stdrk /= 1000;
                    stdrk *= (6 * 0.789);
                    contnt = stdrk * 13500;
                    if (obj.gndr == "Male")
                        gdcons = 0.75;
                    else
                        gdcons = 0.66;
                    wght = Convert.ToDouble(obj.wt) * gdcons;
                    contnt /= wght;
                    contnt /= 10;
                    var tm = DateTime.Parse(obj.tim, CultureInfo.InvariantCulture);
                    double meta = (tm.Hour * 15) + (tm.Minute * 0.25);
                    contnt -= meta;
                    alc += contnt;
                }
            }





            if (alc > 50)
            {
                double remtime;
                remtime = (alc - 50) / 0.25;
                int hr = (int)remtime / 60;
                int min = (int)remtime % 60;
                //Console.Write(Math.Round(remtime, 2));
                CustomMessageBox messageBox = new CustomMessageBox()
                {
                    Caption = "Not Safe",
                    Message = "Your BAC is " + alc + "\nYou are not safe to drive\nYou can drive safe after " + hr + ":" + min + " hrs",
                    LeftButtonContent = "OK",
                    IsFullScreen = true
                };
                messageBox.Show();

            }
            else
            {
                CustomMessageBox messageBox2 = new CustomMessageBox()
                {
                    Caption = "Safe",
                    Message = "Your BAC is " + alc + "\nYou are safe to drive",
                    LeftButtonContent = "OK",
                    IsFullScreen = true
                };
                messageBox2.Show();
            }
        }

        
    }
}