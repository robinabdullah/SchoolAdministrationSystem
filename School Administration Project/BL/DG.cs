using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Administration_Project.BL
{
    class EligibleStudentList
    {
        private string id;
        private string mobile;
        private string grade;
        private string group;
        private string gender;
        private string name;
        private string viva;
        private string written;        
        private string total;
        private string eligibility;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        public string Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Viva
        {
            get
            {
                return viva;
            }

            set
            {
                viva = value;
            }
        }

        public string Written
        {
            get
            {
                return written;
            }

            set
            {
                written = value;
            }
        }

        public string Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string Eligibility
        {
            get
            {
                return eligibility;
            }

            set
            {
                eligibility = value;
            }
        }
    }
}
