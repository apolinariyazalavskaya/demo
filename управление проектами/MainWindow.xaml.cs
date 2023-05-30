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

namespace управление_проектами
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frame_.Navigate(new pages_new.PageMain());
        }

        private void Frame__ContentRendered(object sender, EventArgs e)
        {

        }
       
        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            if (Frame_.CanGoBack)
                Frame_.GoBack();

        }
    }
}