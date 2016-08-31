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

            List<DAL.Admission_Student> list = new List<DAL.Admission_Student>();

            var a = from e in db.Admission_Students
                    select e;

            foreach(DAL.Admission_Student aStd in a)
            {
                list.Add(aStd);
            }

            dataGrid.ItemsSource = list;

            
            
        }
    }
}
