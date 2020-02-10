﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAdatkotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Mintaszoveg = "Hello";
        }

        private string mintaszoveg;
        public string Mintaszoveg {

            get { return mintaszoveg; }

            set {
                mintaszoveg = value;
                if (null!=this.PropertyChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Mintaszoveg"));
                }
            }


        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
