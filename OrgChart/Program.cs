using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{
    class Program
    {
        public static System.Collections.Generic.List<Employee> OrgChart;
        public static System.Collections.Generic.List<EmployeeReverse> OrgChartReverse;

        static void Main(string[] args)
        {
            OrgChartVersion1();

            // REVERSE EMPLOYEE ALGORITHM
            OrgChartVersion2();
            Console.ReadLine();
        }

        private static void OrgChartVersion1()
        {
            PopulateOrganizationChart(ref OrgChart);

            //// Validate reports Counts
            ValidateEmployee("Bill", 3);
            ValidateEmployee("Sam", 0);
            ValidateEmployee("Fred", 1);
            ValidateEmployee("Jane", 0);
            ValidateEmployee("Alice", 0);
            //ValidateEmployee("Bing", 0);

            // Display details for each employ
            
            Console.WriteLine("ORGANIZATION CHART");
            foreach (var emp in OrgChart)
            {
                Console.WriteLine("{0}  has {1} reports", emp.Name, emp.ReportCount);

                foreach (var rep in emp.Reports)
                {
                    Console.WriteLine("\t {0}", rep.Name);
                }
            }
        }

        private static void ValidateEmployee(string name, int expected)
        {
            Employee employeeReturned = OrgChart.Find(Name => Name.Name == name);

            Debug.Assert(employeeReturned != null, "Person Found");
            Debug.Assert(employeeReturned.Name == name, "Person Found");
            Debug.Assert(employeeReturned.ReportCount == expected, "Invalid Report Count ");
        }

        private static void PopulateOrganizationChart(ref List<Employee> OrgChart)
        {
            var bill = new Employee { Name = "Bill" };
            var sam = new Employee { Name = "Sam" };
            var fred = new Employee { Name = "Fred" };
            var jane = new Employee { Name = "Jane" };
            var alice = new Employee { Name = "Alice" };

            //Add reprts
            bill.Reports.Add(sam);
            bill.Reports.Add(fred);
            bill.Reports.Add(jane);
            fred.Reports.Add(alice);

            // Populate Organization Chart
            OrgChart = new List<Employee>  {bill, 
                                            fred, 
                                            sam, 
                                            jane, 
                                            alice
            };


        }


        static void OrgChartVersion2()
        {
            // Populate Reverse Collection (Reverse refers to each employee details who there manager is rather than
            // who there subordinates are
            var bill = new EmployeeReverse { Name = "Bill" };
            var sam = new EmployeeReverse { Name = "Sam", ReportsTo = bill };
            var fred = new EmployeeReverse { Name = "Fred", ReportsTo = bill };
            var jane = new EmployeeReverse { Name = "Jane", ReportsTo = bill };
            var alice = new EmployeeReverse { Name = "Alice", ReportsTo = fred };

            Console.WriteLine("************************");
            Console.WriteLine("REVERSE ORG CHART LOGIC");

            Program.OrgChartReverse = new List<EmployeeReverse>  {bill, 
                                            fred, 
                                            sam, 
                                            jane, 
                                            alice
            };
            foreach (var item in OrgChartReverse)
            {
                Console.WriteLine("{0}, has {1} reports", item.Name, item.ReportCount());

                foreach (var r in item.Reports ())
                {
                    Console.WriteLine("\t {0}", r.Name);
                }
            }
        }


    }




}
