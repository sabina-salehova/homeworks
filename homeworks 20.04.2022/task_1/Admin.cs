using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class Admin:User
    {
        public bool isSuperAdmin;
        public string section;
        public Admin(string Username, string Password, bool IsSuperAdmin, string Section) :base(Username, Password)
        {
            isSuperAdmin = IsSuperAdmin;
            section = Section;            
        }
    }
}
