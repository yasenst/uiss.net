﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string lastname { get; set; }
        public string faculty { get; set; }
        public string specialty { get; set; }
        public string degree { get; set; }
        public string status { get; set; }
        public string number { get; set; }
        public int year { get; set; }
        public int potok { get; set; }
        public int group { get; set; }

        public Student(string n, string sur, string last,
                        string fac, string spec, string deg,
                        string stat, string num, int y, int p, int g)
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
        }
    }
}
