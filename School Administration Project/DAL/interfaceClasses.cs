
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Administration_Project;

namespace School_Administration_Project.DAL
{
    public interface StudentInt
    {
        
        List<Student> getAllStudents();
        Student getStudent(string id);

        bool addStudent(string admission_Student_ID);

        void updateStudent(Student student);
        void deleteStudent(Student student);
    }

    public interface AdmissionStudentInt
    {
        void addAdmissionStudent(Admission_Student adStd);
        List<Admission_Student> getAllAdmissionStudent();
        Admission_Student getAdmissionStudent(string id);        
        void updateAdmissionStudent(Admission_Student AdmissionStudent);
        void deleteAdmissionStudent(Admission_Student AdmissionStudent);
    }

    public interface AdminInterface
    {
        bool addAdmin(Admin admin);
    }
}
