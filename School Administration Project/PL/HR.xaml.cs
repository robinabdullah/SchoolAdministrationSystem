using System;
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
    /// Interaction logic for HR.xaml
    /// </summary>
    public partial class HR : MetroWindow
    {
        public HR()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Close();
        }

        private void Button_Admin_Body_Recruitment(object sender, RoutedEventArgs e)
        {
            HR_Admin_Body_Recruitment adminBodyRecruitment = new HR_Admin_Body_Recruitment();
            adminBodyRecruitment.Show();
            this.Close();
        }

        private void Button_Teacher_Recruitment(object sender, RoutedEventArgs e)
        {
            HR_Teacher_Recruitment teacherRecruitment = new HR_Teacher_Recruitment();
            teacherRecruitment.Show();
            this.Close();
        }

        private void Button_Staff_Recruitment(object sender, RoutedEventArgs e)
        {
            Edit_Profile edit = new Edit_Profile();
            edit.Show();
            this.Close();
        }

        private void Button_Assign_Courses_To_Teacher(object sender, RoutedEventArgs e)
        {
            Delete_Profile ep = new Delete_Profile();
            ep.Show();
            this.Close();
        }

        private void Button_Organizational_Profile(object sender, RoutedEventArgs e)
        {
            Organizational_Profile organizationalProfile = new Organizational_Profile();
            organizationalProfile.Show();
            this.Close();
        }

        private void Button_Employees_Task_Assignment(object sender, RoutedEventArgs e)
        {
            Employee_Task_Assignment ass = new Employee_Task_Assignment();

            ass.Show();
            this.Close();
        }
    }
}
