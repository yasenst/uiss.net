using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentRepository
{
    public class StudentData
    {
        static private List<Student> _testStudents = new List<Student>();

        static public List<Student> TestStudents
        {
            get
            {
                initStudentData();
                return _testStudents;
            }
            private set
            {

            }
        }

        static private void initStudentData()
        {
            _testStudents = new List<Student>();
            _testStudents.Add(new Student("Yasen", "Yasenov", "Yasenski", "FKST", "KSI", "Bachelor", "active", 82, 3, 9, 44));
            _testStudents.Add(new Student("Ivan", "Yasenov", "Yasenski", "FKST", "KSI", "Master", "active", 83, 5, 8, 13));
            _testStudents.Add(new Student("Georgi", "Yasenov", "Yasenski", "FKST", "KSI", "Bachelor", "active", 120, 1, 9, 46));
            _testStudents.Add(new Student("Andrey", "Yasenov", "Yasenski", "FKST", "KSI", "Bachelor", "active", 101, 4, 10, 51));
        }

        static public Student getStudentByFacultyNumber(int facNum)
        {
            
            StudentContext context = new StudentContext();

            Student result =
            (from st in context.Students
             where st.number == facNum
             select st).FirstOrDefault();
            return result;
            
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
