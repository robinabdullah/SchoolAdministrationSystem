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
using School_Administration_Project.BL;
using School_Administration_Project.DAL;
using MahApps.Metro.Controls.Dialogs;

namespace School_Administration_Project.PL
{
    /// <summary>
    /// Interaction logic for Admission_Eligibility.xaml
    /// </summary>
    public partial class Admission_Eligibility : MahApps.Metro.Controls.MetroWindow
    {
        public Admission_Eligibility()
        {
            InitializeComponent();
        }



        private async void searchButton_Click(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext
               (DataAccessClassLinq.connectionStringLinq);

            AdmissionStudentIntImplementation a = new AdmissionStudentIntImplementation();

            DAL.Admission_Student st = a.getAdmissionStudent(id.Text);



            if (st == null)
            {
                fullName.Clear();
                addmissionSession.Clear();
                group.Clear();
                interestedGrade.Clear();
                gender.Clear();
                group.Clear();
                eligibleMarks.Content = "Written :     Viva : ";
                teacherIDs.Content = "Written :    Viva : ";
                written_mark.Clear();
                vivaMark.Clear();
                Total.Clear();
                Eligibility.Content = "Unknown";
                MahApps.Metro.Controls.Dialogs.MessageDialogResult result = await this.ShowMessageAsync("Error!", "Student not found.");

            }
            else
            {
                Admission_Exam_Result stResult = db.Admission_Exam_Results.FirstOrDefault(ee => ee.Admission_Student_ID.Equals(st.Admission_Student_ID));

                fullName.Text = st.Full_Name;
                addmissionSession.Text = st.Admission_Session;
                group.Text = st.Group;
                interestedGrade.Text = st.Interested_Grade;
                gender.Text = st.Gender;
                group.Text = st.Group;
                if (stResult != null)
                {
                    eligibleMarks.Content = "Written : " + stResult.Writtern_Exam_Mark + "   Viva : " + stResult.Viva_Exam_Mark;
                    teacherIDs.Content = "Written : " + stResult.Written_Examiner_ID + "   Viva : " + stResult.Viva_Examiner_ID;

                    written_mark.Text = stResult.Writtern_Exam_Mark;
                    vivaMark.Text = stResult.Viva_Exam_Mark;

                    double total = Double.Parse(stResult.Writtern_Exam_Mark) + Double.Parse(stResult.Viva_Exam_Mark);

                    Total.Text = total.ToString();

                    BusinessRules r = new BusinessRules();
                    bool test = r.checkEligibility(stResult.Writtern_Exam_Mark, stResult.Viva_Exam_Mark);

                    if (test == true)
                        Eligibility.Content = "Yes";
                    else
                        Eligibility.Content = "No";
                }
                else
                {
                    written_mark.Text = "0";
                    vivaMark.Text = "0";
                    eligibleMarks.Content = "Written : " + 0 + "   Viva : " + 0;
                    teacherIDs.Content = "Written : " + 0 + "   Viva : " + 0;
                    Total.Text = "0";
                    Eligibility.Content = "No";

                    MahApps.Metro.Controls.Dialogs.MessageDialogResult result = await this.ShowMessageAsync("Error!", "Viva and Written marks weren't added yet !!");
                }


            }
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            Admission a = new Admission();
            a.Show();
            this.Close();
        }
    }
}
