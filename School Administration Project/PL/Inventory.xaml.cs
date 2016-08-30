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
    /// Interaction logic for Inventory.xaml
    /// </summary>
    public partial class Inventory : MetroWindow
    {

        public Inventory()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Close();
        }

        private void Button_DONE(object sender, RoutedEventArgs e)
        {
            if (Edit.Content.ToString() == "EDIT")
            {
                Edit.Content = "DONE";
                Printer.IsEnabled = true;
                Computer.IsEnabled = true;
                Mouse.IsEnabled = true;
                Keyboard.IsEnabled = true;
                Projector.IsEnabled = true;
                Camera.IsEnabled = true;
                WhiteBoard.IsEnabled = true;
                Marker.IsEnabled = true;
                Pencil.IsEnabled = true;
                Soap.IsEnabled = true;
                PaperBundle.IsEnabled = true;
                Pen.IsEnabled = true;
                Duster.IsEnabled = true;
                GeometryBox.IsEnabled = true;
                Ruler.IsEnabled = true;
                Chair.IsEnabled = true;
                Bench.IsEnabled = true;
                Table.IsEnabled = true;

                PrinterUpDown.IsEnabled = true;
                ComputerUpDown.IsEnabled = true;
                MouseUpDown.IsEnabled = true;
                KeyboardUpDown.IsEnabled = true;

            }
            else
            {
                Edit.Content = "EDIT";
                Printer.IsEnabled = false;
                Computer.IsEnabled = false;
                Mouse.IsEnabled = false;
                Keyboard.IsEnabled = false;
                Projector.IsEnabled = false;
                Camera.IsEnabled = false;
                WhiteBoard.IsEnabled = false;
                Marker.IsEnabled = false;
                Pencil.IsEnabled = false;
                Soap.IsEnabled = false;
                PaperBundle.IsEnabled = false;
                Pen.IsEnabled = false;
                Duster.IsEnabled = false;
                GeometryBox.IsEnabled = false;
                Ruler.IsEnabled = false;
                Chair.IsEnabled = false;
                Bench.IsEnabled = false;
                Table.IsEnabled = false;

                PrinterUpDown.IsEnabled = false;
                ComputerUpDown.IsEnabled = false;
                MouseUpDown.IsEnabled = false;
                KeyboardUpDown.IsEnabled = false;

            }

            


        }

        





    }
}
