        using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserLogin
{
    public class User
    {
        public System.Int32 UserId { get; set; }
        public System.String username { get; set; }
        public System.String password { get; set; }
        public System.Int32 number { get; set; }
        public UserRoles role { get; set; }
        public System.DateTime dateCreated { get; set; }
        public System.DateTime? activeTo { get; set; }

        public User() { }
    }
}
