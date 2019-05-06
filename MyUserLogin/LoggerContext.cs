using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyUserLogin
{
    class LoggerContext : DbContext
    {
        public LoggerContext()
        : base(Properties.Settings.Default.DbConnect)
        { }

        public DbSet<Log> Logs { get; set; }
    }
}
