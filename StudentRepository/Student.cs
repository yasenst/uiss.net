using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class Student
    {
        public int StudentId { get; set; }
        public System.String name { get; set; }
        public string surname { get; set; }
        public string lastname { get; set; }
        public string faculty { get; set; }
        public string specialty { get; set; }
        public string degree { get; set; }
        public string status { get; set; }
        public int number { get; set; }
        public int year { get; set; }
        public int potok { get; set; }
        public int group { get; set; }
        public byte[] Photo { get; set; }

        public Student() { }

        public Student(string n, string sur, string last,
                        string fac, string spec, string deg,
                        string stat, int num, int y, int p, int g)
        {
            name = n;
            surname = sur;
            lastname = last;
            faculty = fac;
            specialty = spec;
            degree = deg;
            status = stat;
            number = num;
            year = y;
            potok = p;
            group = g;
            Photo = null;
        }
    }
}
