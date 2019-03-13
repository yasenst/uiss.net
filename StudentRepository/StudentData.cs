using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentRepository
{
    class StudentData
    {
        static private Student testStudent;

        static public Student TestStudent
        {
            get
            {
                return testStudent;
            }
            private set
            {

            }
        }

        static public Student getStudentByFacultyNumber(List<Student> students, string facultyNumber)
        {
            foreach (Student student in students)
            {
                if (student.number.Equals(facultyNumber))
                    return student;
            }
            return null;
        }

        static public string prepareCertificate(Student student)
        {
            return String.Format("{0} {1} has successfully complete year {2} towards getting a {3} degree in {4}.{5}",
                                            student.name, student.lastname, student.year, student.degree, student.specialty, Environment.NewLine);
            
        }

        static public bool saveCertificate(string certificate)
        {
            if (File.Exists(@"d:\\my documents\visual studio 2017\\Projects\\YS_44_Yasen\\StudentRepository\certificates.txt") == true)
            {
                File.AppendAllText(@"d:\\my documents\visual studio 2017\\Projects\\YS_44_Yasen\\StudentRepository\certificates.txt", certificate);
                return true;
            }
            return false;
        }

        static public bool saveCertificate(List<Student> students)
        {
            
            StringBuilder sb = new StringBuilder();

            foreach(Student student in students)
            {
                if (student.year > 2)
                {
                    sb.Append(prepareCertificate(student));

                }
            }
            
            if (File.Exists(@"d:\\my documents\visual studio 2017\\Projects\\YS_44_Yasen\\StudentRepository\allCertificates.txt") == true)
            {
                File.AppendAllText(@"d:\\my documents\visual studio 2017\\Projects\\YS_44_Yasen\\StudentRepository\allCertificates.txt", sb.ToString());
                return true;
            }

            return false;
        }
    }
}
