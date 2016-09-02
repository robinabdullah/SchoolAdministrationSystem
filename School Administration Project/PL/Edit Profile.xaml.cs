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
using School_Administration_Project.DAL;
using MahApps.Metro.Controls.Dialogs;

namespace School_Administration_Project.PL
{
    /// <summary>
    /// Interaction logic for Edit_Profile.xaml
    /// </summary>
    public partial class Edit_Profile : MetroWindow
    {
        public Edit_Profile()
        {
            InitializeComponent();

            First.IsEnabled = false;
            Last.IsEnabled = false;
            Father.IsEnabled = false;
            Mother.IsEnabled = false;
            Gender.IsEnabled = false;
            Blood.IsEnabled = false;
            Status.IsEnabled = false;
            Marital.IsEnabled = false;
            Designation.IsEnabled = false;
            Address.IsEnabled = false;
            Email.IsEnabled = false;
            Mobile.IsEnabled = false;

        }

        private async void Button_DELETE(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            Teacher editTeacher = db.Teachers.FirstOrDefault(ex => ex.Teacher_ID.Equals(ID.Text));
            //db.Teachers.DeleteOnSubmit(deleteTeacher);

            editTeacher.First_Name = First.Text;
            editTeacher.Last_Name = Last.Text;
            editTeacher.Fathers_Name = Father.Text;
            editTeacher.Mothers_Name = Mother.Text;
            editTeacher.Gender = Gender.Text;
            editTeacher.Blood_Group = Blood.Text;
            editTeacher.Status = Status.Text;
            editTeacher.Marital_Status = Marital.Text;
            editTeacher.Designation = Designation.Text;
            editTeacher.Address = Address.Text;
            editTeacher.Email = Email.Text;
            editTeacher.Mobile = Mobile.Text;

            try
            {
                db.SubmitChanges();
            }
            catch
            {
                await this.ShowMessageAsync("Error", "Information update failed.");
            }
            await this.ShowMessageAsync("Information", "Information update successful.");

            HR hr = new HR();
            hr.Show();
            this.Show();

        }

        private async void Button_DONE(object sender, RoutedEventArgs e)
        {
            First.IsEnabled = true;
            Last.IsEnabled = true;
            Father.IsEnabled = true;
            Mother.IsEnabled = true;
            Gender.IsEnabled = true;
            Blood.IsEnabled = true;
            Status.IsEnabled = true;
            Marital.IsEnabled = true;
            Designation.IsEnabled = true;
            Address.IsEnabled = true;
            Email.IsEnabled = true;
            Mobile.IsEnabled = true; 

            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            var s = from a in db.Students
                    where a.Student_ID == ID.Text
                    select a;

            var t = from a in db.Teachers
                    where a.Teacher_ID == ID.Text
                    select a;



            //teach.DOB = DateTime.Now;
            //teach.Joined_Date = DateTime.Now;
            //teach.Status = "Active";

            //teach.Mobile = Mobile.Text;
            //teach.Designation = Designation.Text;
            //teach.Address = Address.Text;
            //teach.Email = Email.Text;
            bool flag = false;
            foreach (Teacher obj in t)
            {
                if (obj.Teacher_ID.Equals(ID.Text))
                {
                    flag = true;
                    First.Text = obj.First_Name;
                    Last.Text = obj.Last_Name;
                    Father.Text = obj.Fathers_Name;
                    Mother.Text = obj.Mothers_Name;
                    Gender.Text = obj.Gender;
                    Blood.Text = obj.Blood_Group;
                    Status.Text = obj.Status;
                    Marital.Text = obj.Marital_Status;
                    Designation.Text = obj.Designation;
                    Address.Text = obj.Address;
                    Email.Text = obj.Email;
                    Mobile.Text = obj.Mobile;

                }
            }
            if (flag == false)
            {
                await this.ShowMessageAsync("Error", "Student not found.");
                First.Text = "";
                Last.Text = "";
                Father.Text = "";
                Mother.Text = "";
                Gender.Text = "";
                Blood.Text = "";
                Status.Text = "";
                Marital.Text = "";
                Designation.Text = "";
                Address.Text = "";
                Email.Text = "";
                Mobile.Text = "";
            }

            
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Close();
        }

    }
}
