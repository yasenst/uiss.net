﻿        using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserLogin
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string number { get; set; }
        public UserRoles role { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime activeTo { get; set; }

        
    }
}
