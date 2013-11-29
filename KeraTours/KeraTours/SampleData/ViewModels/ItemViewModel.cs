using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace KeraTours.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private string _lineOne;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineOne
        {
            get
            {
                return _lineOne;
            }
            set
            {
                if (value != _lineOne)
                {
                    _lineOne = value;
                    NotifyPropertyChanged("LineOne");
                }
            }
        }

        private string _lineTwo;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineTwo
        {
            get
            {
                return _lineTwo;
            }
            set
            {
                if (value != _lineTwo)
                {
                    _lineTwo = value;
                    NotifyPropertyChanged("LineTwo");
                }
            }
        }

        private string _lineThree;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string LineThree
        {
            get
            {
                return _lineThree;
            }
            set
            {
                if (value != _lineThree)
                {
                    _lineThree = value;
                    NotifyPropertyChanged("LineThree");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _kerala;
        public string Kerala
        {
            get
            {
                return _kerala;
            }
            set
            {
                if (value != _kerala)
                {
                    _kerala = value;
                    NotifyPropertyChanged("Kerala");
                }
            }
        }

        private string _Alapuzha;
        public string Alapuzha
        {
            get
            {
                return _Alapuzha;
            }
            set
            {
                if (value != _Alapuzha)
                {
                    _Alapuzha = value;
                    NotifyPropertyChanged("Alapuzha");
                }
            }
        }

        private string _Bekal;
        public string Bekal
        {
            get
            {
                return _Bekal;
            }
            set
            {
                if (value != _Bekal)
                {
                    _Bekal = value;
                    NotifyPropertyChanged("Bekal");
                }
            }
        }

        private string _Fort;
        public string Fort
        {
            get
            {
                return _Fort;
            }
            set
            {
                if (value != _Fort)
                {
                    _Fort = value;
                    NotifyPropertyChanged("Fort");
                }
            }
        }

        private string _Kumarakom;
        public string Kumarakom
        {
            get
            {
                return _Kumarakom;
            }
            set
            {
                if (value != _Kumarakom)
                {
                    _Kumarakom = value;
                    NotifyPropertyChanged("Kumarakom");
                }
            }
        }

        private string _Munnar;
        public string Munnar
        {
            get
            {
                return _Munnar;
            }
            set
            {
                if (value != _Munnar)
                {
                    _Munnar = value;
                    NotifyPropertyChanged("Munnar");
                }
            }
        }

        private string _Thekkady;
        public string Thekkady
        {
            get
            {
                return _Thekkady;
            }
            set
            {
                if (value != _Thekkady)
                {
                    _Thekkady = value;
                    NotifyPropertyChanged("Thekkady");
                }
            }
        }

        private string _Wayanad;
        public string Wayanad
        {
            get
            {
                return _Wayanad;
            }
            set
            {
                if (value != _Wayanad)
                {
                    _Wayanad = value;
                    NotifyPropertyChanged("Wayanad");
                }
            }
        }
    }
}