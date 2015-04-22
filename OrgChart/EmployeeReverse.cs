using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{
    class EmployeeReverse
    {
        public string Name { get; set; }
        public EmployeeReverse ReportsTo { get; set; }

        public int ReportCount()
        {
            return HowManyPeopleReportToManager();
        }


        /// <summary>
        /// Returns a list of all the people who report to this current employee.
        /// </summary>
        /// <returns></returns>
        public List<EmployeeReverse> Reports()
        {
            // To generate a list of reports we need to check all the members 
            // of the collection to find name matches.
            var l = new List<EmployeeReverse>();

            if (this != null)
            {
                foreach (var sitem in Program.OrgChartReverse)
                {
                    if (sitem.ReportsTo != null)
                    {
                   
                        if (sitem.ReportsTo == this)
                            l.Add(sitem);

                    }

                }
            }
            return l;
        }


        /// <summary>
        /// Count the number of reports
        /// </summary>
        /// <returns></returns>
        private int HowManyPeopleReportToManager()
        { 
            return Reports().Count ;
        }
    }
}
