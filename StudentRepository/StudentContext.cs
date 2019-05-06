﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentRepository
{
    class StudentContext : DbContext
    {
        public StudentContext()
        : base(Properties.Settings.Default.DbConnect)   
        { }

        public DbSet<Student> Students { get; set; }
    }
}
