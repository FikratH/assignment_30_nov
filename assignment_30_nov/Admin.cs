using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_30_nov
{
    public class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string user, string password, bool isSuperAdmin, string section):base(user, password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }
    }
}
