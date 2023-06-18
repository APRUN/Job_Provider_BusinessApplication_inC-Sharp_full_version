using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.BL;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.UI
{
    class MenuUI
    {
        private static string[] loginmenu = { "Sign Up", "Sign In", "Exit" };
        private static string[] adminmenu = { "Add a Job", "Remove a Job", "Edit a Job details", "View available jobs", "View Available Employees", "View available Users", "View Messages", "Exit" };
        private static string[] usermenu = { "Apply for A job", "View Available Jobs", "Search for a Job", "Left Job", "Replace my Job", "View my job", "Chat with Admin", "return" };

        private static void PrintMenu(string[] menuitems)
        {
            for (int i = 0; i < menuitems.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}.", i + 1);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(menuitems[i]);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void DisplayMenu()
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), "User", "Login Menu","None");
            PrintMenu(loginmenu);
        }
        public static void Menu(User user)
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), AppUI.headerName(user), "Admin Menu", AppUI.headerRole(user));
            PrintMenu(usermenu);
        }
        public static void Menu(User user,string none)
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(),AppUI.headerName(user),"User Menu",AppUI.headerRole(user));
            PrintMenu(adminmenu);
        }

    }
}
