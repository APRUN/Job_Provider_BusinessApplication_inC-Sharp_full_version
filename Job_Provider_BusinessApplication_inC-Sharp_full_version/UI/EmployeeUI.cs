using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.DL;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.UI
{
    class EmployeeUI
    {
        public static void Print_allEmployees()
        {
            Console.WriteLine("Name\t\tJob Name\t\tContact\t\tCity\t   Category");
            foreach(var temp in EmployeeList.getEmployee_list())
            {

                Console.WriteLine(temp.get_AppliedEmp_name()+"\t"+temp.get_AppliedEmp_JobName()+"\t" + temp.get_EmployeeContact()+ "\t" + temp.get_EmployeeLocality()+"\t"+temp.get_appliedEmpJob_category());
            }
            AppUI.Halt();
        }
    }
}
