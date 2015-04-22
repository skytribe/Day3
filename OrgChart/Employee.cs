using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{
    class Employee
    {
        public string Name { get; set; }
        public System.Collections.Generic.List<Employee> Reports { get; set; }

        public Employee()
        {
            Reports = new System.Collections.Generic.List<Employee>();
        }

       

        public int ReportCount
        {
            get
            {
                return Reports.Count;
            }
        }
    }   
}
