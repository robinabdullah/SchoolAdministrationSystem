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
using School_Administration_Project.BL;
using School_Administration_Project.DAL;

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
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            DAL.Admin admin = new DAL.Admin();

            admin.First_Name = fn.Text;
            admin.Last_Name = ln.Text;
            admin.Fathers_Name = fa.Text;
            admin.Mothers_Name = mo.Text;
            admin.Gender = gen.Text;
            admin.Blood_Group = bl.Text;
            admin.DOB = DateTime.Parse(dob.ToString());

            if (marr.IsChecked == true)
            {
                admin.Marital_Status = "Married";
            }
            else if(unmarr.IsChecked == true)
            {
                admin.Marital_Status = "Unmarried";
            }

            admin.Religoin = religionList.Items.GetItemAt(0).ToString();
            admin.Mobile = mob.Text;
            admin.Designation = des.Text;
            admin.Address = add.Text;
            admin.Email = email.Text;
            admin.Admin_ID = fn.Text;
            
            var max = db.Admins.OrderByDescending(i => i.Admin_ID).FirstOrDefault();
            // InComplete Code

            db.Admins.InsertOnSubmit(admin);
            db.SubmitChanges();

            HR hr = new HR();
            hr.Show();
            this.Close();
        }
    }
}
