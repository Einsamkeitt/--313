﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Window0 : Window
    {
        System.Windows.Media.Brush color;
        bool colorFlag = true;

        public Window0()
        {
            //InitializeComponent();
            Application.LoadComponent(this, new Uri("Window0.xaml", UriKind.Relative));

            Btn1.Click += new RoutedEventHandler(Btn1_Click);
            color = this.Window.Background;
        }

        void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (colorFlag)
                this.Window.Background = System.Windows.Media.Brushes.Purple;
            else
                this.Window.Background = color;

            colorFlag = !colorFlag;
        }
    }
}
