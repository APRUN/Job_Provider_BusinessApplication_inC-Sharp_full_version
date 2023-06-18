using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.BL;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.DL;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.UI
{
    class UserUI
    {
      public static void SignUp_result(bool state)
        {
            if(state==true)
            {
                Console.WriteLine("Signed Up Successfully.");
            }
            else if(state==false)
            {
                Console.WriteLine("Couldn't Sign Up.");
            }
            AppUI.Halt();
        }
        public static void SignIn_Failed()
        {
            Console.WriteLine("Could'nt Sign In.");
            AppUI.Halt();
        }
        public static User Take_credentials()
        {
            AppUI.logo();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter Name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter Password: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            while(password.Length<5)
            {
                AppUI.InvalidPassword();
                password = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter your Role(user/admin): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string role = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.Gray;
            User user = new User(name,password,role);
            return user;          
        }
        public static void Print_allUsers(UserList userlist,User user)
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), AppUI.headerName(user), "Printing User Lists", AppUI.headerRole(user));
            Console.WriteLine("Username\t\tPassword\t\tRole");
            foreach(var temp_user in userlist.get_userList())
            {
                Console.WriteLine(temp_user.getname()+ "\t\t\t" + temp_user.getpassword()+ "\t\t\t" + temp_user.getrole());
            }
            AppUI.Halt();
        }
        public static void Print_partialEmp_info(Employee employee)
        {
            Console.WriteLine("Name\t\tJob Name\t\tCity");
            {
                foreach(Employee temp_emp in EmployeeList.getEmployee_list())
                {
                    if(temp_emp.get_AppliedEmp_name()==employee.get_AppliedEmp_name())
                    {
                        Console.WriteLine(temp_emp.get_AppliedEmp_name()+"\t\t  "+ temp_emp.get_AppliedEmp_JobName()+"\t\t\t"+ temp_emp.get_EmployeeLocality());               
                    }
                }
                AppUI.Halt();
                return;
            }
        }
    }
}
