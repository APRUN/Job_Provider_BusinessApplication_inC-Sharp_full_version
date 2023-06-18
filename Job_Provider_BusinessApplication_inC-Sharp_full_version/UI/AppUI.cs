using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.BL;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.DL;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.UI
{
    class AppUI
    {
        public static void logo()
        {
            Console.Clear();
            Console.WriteLine("\n ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t  _     _       _            _ _____       _   ");
            Console.WriteLine("\t\t\t | |   (_)     | |          | |  _  |     | | ");
            Console.WriteLine("\t\t\t | |    _ _ __ | | _____  __| | | | |_   _| |_");
            Console.WriteLine("\t\t\t | |   | | '_ \\| |/ / _ \\/ _` | | | | | | | __|");
            Console.WriteLine("\t\t\t | |___| | | | |   <  __/ (_| \\ \\_/ / |_| | |_ ");
            Console.WriteLine("\t\t\t \\_____/_|_| |_|_|\\_\\___|\\__,_|\\___/ \\__,_|\\__|");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");

        }

        public static void Header(string ad,string username,string menu,string role)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|____________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("         AD:             ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ad + "         ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("         Current User:   ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(username + "    ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("         Current Menu:   ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(menu + "     ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("         Current Role :  ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(role + "    ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|____________________________________________________________________________________________");
            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void Halt()
        {
        
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Press any key to Continue...");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();

        }
        public static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Sorry!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
            Halt();
        }
        public static void ErrorEnterInvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error! Enter Valid Input.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }
        public static string TakeInput(string message)
        {
            string input;
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Enter {0}",message);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                input = Console.ReadLine().ToLower();
               if(input=="")
               {
                   ErrorEnterInvalidInput();
               }
               else
               {
                   break;
               }
            }
            return input;
        }
        public static float TakeInput(string message,float num)
        {
            float input;
            while(!float.TryParse(TakeInput(message),out input))
            {
                ErrorEnterInvalidInput();
            }
            return input;
        }
        public static int TakeInput(string message,string num)
        {
            int input;
            while(int.TryParse(TakeInput(message),out input))
            {
                ErrorEnterInvalidInput();
            }
            return input;
        }
        public static int Take_Choice()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter your Choice: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (!int.TryParse(Console.ReadLine(),out int choice))
            {
                return -1;  
            }
            else
            {
                return choice;  
            }
        }
        public static void InvalidChoice()
        {
            Console.WriteLine("Invalid Choice.");
            Halt();
        }
        public static void Press_nReturn()
        {
            Console.WriteLine("0. Return");
            Halt();
        }
        public static void Done(string message)
        {
            Console.WriteLine("Done! "+message);
            Halt();
        }
        public static string headerAd()
        {
            return ("Summer Internships are available for Students") ;
        }
        public static string headerRole(User user)
        {
            if(user.getrole()=="admin")
            {
                return "admin";
            }
            else if(user.getrole()=="user")
            {
                return "user";
            }
            return null;
        }
        public static string headerName(User user)
        {
            return user.getname();
        }
        public static void Print_texts()
        {
            foreach (string temp_text in TextList.getTexts())
            {
                Console.WriteLine(temp_text);
            }
        }
        public static void InvalidPassword()
        {
            Console.WriteLine("Password must be of 5 Characters atleast.");
            Halt();
        }


    }
}
 