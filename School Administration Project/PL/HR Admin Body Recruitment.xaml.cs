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
    /// Interaction logic for HR_Admin_Body_Recruitment.xaml
    /// </summary>
    public partial class HR_Admin_Body_Recruitment : MetroWindow
    {
        public HR_Admin_Body_Recruitment()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Close();
        }

        private void Button_DONE(object sender, RoutedEventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Close();
        }
    }
}
