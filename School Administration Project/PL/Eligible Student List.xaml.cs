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
using School_Administration_Project.BL;
using School_Administration_Project.DAL;

namespace School_Administration_Project.PL
{
    /// <summary>
    /// Interaction logic for Eligible_Student_List.xaml
    /// </summary>
    public partial class Eligible_Student_List : MahApps.Metro.Controls.MetroWindow
    {
        public Eligible_Student_List()
        {
            InitializeComponent();

            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            List<EligibleStudentListDG> list = new List<EligibleStudentListDG>();

            var a = from e in db.Admission_Students
                    select e;

            EligibleStudentListDG el = new EligibleStudentListDG();

            foreach(DAL.Admission_Student aStd in a)
            {
                el.Id = aStd.Admission_Student_ID;
                el.Name = aStd.Full_Name;
                el.Gender = aStd.Gender;

                list.Add(el);
            }
            
            dataGrid.ItemsSource = list;

            
            
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Admission ad = new Admission();
            ad.Show();
            this.Close();
        }
    }
}
