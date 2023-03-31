using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    internal class connection
    {
        public string adress = System.IO.File.ReadAllText(@"C:\Users\user\Desktop\scholl_project_sqladress.txt");
    }
}
