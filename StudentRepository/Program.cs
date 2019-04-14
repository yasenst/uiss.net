using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class Program
    {
        static public void Main(string[] args)
        {


            List<Student> students = StudentData.TestStudents;
            
            string facultyNumber = Console.ReadLine();

            Student currentStudent = StudentData.getStudentByFacultyNumber(students, facultyNumber);

            string certificate = StudentData.prepareCertificate(currentStudent);

            Console.WriteLine(certificate);

            StudentData.saveCertificate(certificate);

            StudentData.saveCertificate(students);
        }
    }
}
