using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.BL;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.UI;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.DL
{
    class EmployeeList
    {
        private static List<Employee> employees = new List<Employee>();
        public static List<Employee> getEmployee_list()
        {
            return employees;
        }
        public static void Add_anEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public static string Search_MyJob_ByName(string Emp_name)
        {
            foreach (var temp_try in employees)
            {
                if (Emp_name == temp_try.get_AppliedEmp_name())
                {
                    return temp_try.get_AppliedEmp_JobName();
                }
            }
            return null;
        }
    }
}
