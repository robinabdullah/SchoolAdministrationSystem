using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Administration_Project.PL;

namespace School_Administration_Project.DAL
{
    public class StudentIntImplementation : StudentInt
    {
        public void deleteStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> getAllStudents()
        {
            throw new NotImplementedException();
        }

        public Student getStudent(string id)
        {
            throw new NotImplementedException();
        }

        public void updateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }

    public class AdmissionStudentIntImplementation : AdmissionStudentInt
    {
        public void deleteAdmissionStudent(Admission_Student a)
        {
            throw new NotImplementedException();
        }

        public void setWrittenResult(string mark, string teacherID, string stdID)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext
                (DataAccessClassLinq.connectionStringLinq);            

            var max = db.Admission_Exam_Results.OrderByDescending(i => i.Admission_Exam_ID).FirstOrDefault();

            Admission_Exam_Result re = db.Admission_Exam_Results.FirstOrDefault(e => e.Admission_Student_ID.Equals(stdID));

            if (re == null)
            {
                string id = "";
                foreach (char a in max.Admission_Exam_ID)
                {
                    int val = (int)Char.GetNumericValue(a);
                    id = (val + 1).ToString();
                }

                Admission_Exam_Result rs = new Admission_Exam_Result();

                rs.Admission_Exam_ID = id;
                rs.Written_Examiner_ID = teacherID;
                rs.Writtern_Exam_Mark = mark;
                rs.Admission_Student_ID = stdID;
                rs.Viva_Exam_Mark = "0";
                rs.Viva_Examiner_ID = "0";
                db.Admission_Exam_Results.InsertOnSubmit(rs);                
            }
            else
            {
                re.Writtern_Exam_Mark = mark;
                re.Written_Examiner_ID = teacherID;                          
            }

            db.SubmitChanges();

        }
        public void setVivaResult(string mark, string teacherID, string stdID)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext
                (DataAccessClassLinq.connectionStringLinq);

            //var max = db.Admission_Exam_Results.OrderByDescending(i => i.Admission_Exam_ID).FirstOrDefault();

            Admission_Exam_Result re= db.Admission_Exam_Results.FirstOrDefault(e => e.Admission_Student_ID.Equals(stdID));

            if(re != null)
            {
                re.Viva_Examiner_ID = teacherID;
                re.Viva_Exam_Mark = mark;
            }

            db.SubmitChanges();
        }


        public void addAdmissionStudent(Admission_Student  adStd)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext
                (DataAccessClassLinq.connectionStringLinq);

            var max = db.Admission_Students.OrderByDescending(i => i.Admission_Student_ID).First();

            string id = "";
            foreach (char a in max.Admission_Student_ID)
            {
                int val = (int)Char.GetNumericValue(a);
                id = (val + 1).ToString();
            }

            adStd.Admission_Student_ID = id;            

            db.Admission_Students.InsertOnSubmit(adStd);

            db.SubmitChanges();
        }

        public Admission_Student getAdmissionStudent(string id)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext
                (DataAccessClassLinq.connectionStringLinq);

            var temp = from a in db.Admission_Students
                       where a.Admission_Student_ID == id
                       select a;

            foreach (Admission_Student std in temp)
            {
                return std;
            }

            return null;

        }

        public List<Admission_Student> getAllAdmissionStudent()
        {
            throw new NotImplementedException();
        }

        public void updateAdmissionStudent(Admission_Student AdmissionStudent)
        {
            throw new NotImplementedException();
        }
    }
}
