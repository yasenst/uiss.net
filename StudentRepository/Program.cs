using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Yasen", "Yasenov", "Yasenski", "FKST", "KSI", "Bachelor", "active", "081", 3, 9, 44);
            Student s2 = new Student("Ivan", "Yasenov", "Yasenski", "FKST", "KSI", "Master", "active", "206", 5, 8, 13);
            Student s3 = new Student("Georgi", "Yasenov", "Yasenski", "FKST", "KSI", "Bachelor", "active", "120", 1, 9, 46);
            Student s4 = new Student("Andrey", "Yasenov", "Yasenski", "FKST", "KSI", "Bachelor", "active", "101", 4, 10, 51);

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);

            string facultyNumber = Console.ReadLine();

            Student currentStudent = StudentData.getStudentByFacultyNumber(students, facultyNumber);

            string certificate = StudentData.prepareCertificate(currentStudent);

            Console.WriteLine(certificate);

            StudentData.saveCertificate(certificate);

            StudentData.saveCertificate(students);
        }
    }
}
