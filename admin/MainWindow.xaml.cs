﻿using System;
using System.Collections.Generic;
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
using Vasutihalozatok;

namespace admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            varosletrehozas varos = new varosletrehozas();
            varos.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Jaratok railwayPicker = new Jaratok();
            railwayPicker.Left = this.Left;
            railwayPicker.Top = this.Top;
            Jaratok.GetWindow(railwayPicker).Show();
        }
    }
}
