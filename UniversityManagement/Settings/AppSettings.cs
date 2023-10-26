using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Settings
{
    public class AppSettings
    {
        public string DbHost { get; set; }
        public string DbPort { get; set; }
        public DbType DbType { get; set; }
        public string DbName { get; set; }
        public bool WindowsAuthentication { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
