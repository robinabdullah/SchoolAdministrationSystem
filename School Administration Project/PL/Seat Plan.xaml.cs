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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace School_Administration_Project.PL
{
    /// <summary>
    /// Interaction logic for Seat_Plan.xaml
    /// </summary>
    public partial class Seat_Plan : MetroWindow
    {
        public Seat_Plan()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Exam_Control ec = new Exam_Control();
            ec.Show();
            this.Close();
        }

        private void Button_Accounts(object sender, RoutedEventArgs e)
        {
            ECRoom101 ec = new ECRoom101();
            ec.Show();
            this.Close();
        }
    }
}