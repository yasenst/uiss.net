using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserLogin
{
    class Log
    {
        public System.Int32 LogId { get; set; }
        public System.String logMessage { get; set; }

        public Log() { }

        public Log(User user)
        {
            logMessage = user.username.ToString() + " logged at " + DateTime.Now;
        }
    }
}
