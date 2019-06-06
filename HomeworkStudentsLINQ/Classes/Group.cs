using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStudentsLINQ.Classes
{
    public class Group
    {
        private static int groupctr = 0;
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
        public Group(string departmentName)
        {
            DepartmentName = departmentName;
            GroupNumber = ++groupctr;
        }
    }
}
