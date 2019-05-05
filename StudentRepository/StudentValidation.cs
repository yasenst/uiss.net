using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUserLogin;
using StudentRepository;

namespace StudentRepository
{
    public class StudentValidation
    {

        static public Student GetStudentDataByUser(User u)
        {
            if (u.role != UserRoles.STUDENT)
                return null;

            foreach (Student student in StudentData.TestStudents)
            {
                if (u.number == student.number)
                {
                    return student;
                } 
            }

            return null;
        }
    }
}
