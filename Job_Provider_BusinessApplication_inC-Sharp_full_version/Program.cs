using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.BL;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.DL;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.UI;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version
{
    class Program
    {
        public static UserList userlist = new UserList();  //Making a common object of Class Userlist
        public static Employee employee = new Employee();  //Making a common object of Class Employee
        static JobList joblist = new JobList();            //Making a common object of Clas JobList
        static EmployeeList employeelist = new EmployeeList();
        static User copieduser = new User();               //Making an object of User class to store the currently operating ser
        static bool IsUserLoggedIn = false;                //Variabe that verifies login of a user
        public static FileManagement files = new FileManagement();
        static void Main(string[] args)
        {
         //   temp_function();
            files.loadData(userlist);
            files.loadJobData(joblist);
            files.loadEmpData();
            files.storeData(userlist);
            files.storeJobData(joblist);
            files.storeEmpData();
           while(true)
            {
                while(IsUserLoggedIn==false)
                {
                    LogIn_Handler(userlist);             //This function handles the Login of the user
                }
               if(IsUserLoggedIn==true)
                {
                    if(copieduser.getrole()=="user")
                    {
                        temp_function();                 //Its a temporary loading function for jobs 
                        MenuUI.Menu(copieduser);
                        int choice = AppUI.Take_Choice();
                        if(choice==1)
                        {
                            Applying_Fora_Job();        //This function contains the processing for a user to apply for a Job
                        }
                        if(choice==2)
                        {
                            JobUI.PrintJobs_List(joblist,copieduser);     //It will print the Job Lists for the User
                        }
                        if(choice==3)
                        {
                            Search_for_Job();           //This function contains the processing for user to search a Job
                        }
                        if(choice==4)
                        {
                            AppUI.logo();
                            AppUI.Header(AppUI.headerAd(), AppUI.headerName(copieduser), "Removing a Job", AppUI.headerRole(copieduser));
                            Make_job_null();                                //This Function removes a person or fires him from the job
                        }
                        if(choice==5)
                        {
                            AppUI.logo();
                            AppUI.Header(AppUI.headerAd(), AppUI.headerName(copieduser), "Printing Job Lists", AppUI.headerRole(copieduser));
                            string Job_Name =AppUI.TakeInput("Name of Job: ");
                            Replace_myJob(Job_Name);                       //This function replaces the user job with a new exsisting job
                        }
                        if(choice==6)
                        {
                            View_myJob();                                    //This function views basic info of user to user.
                        }
                        if(choice==7)
                        {
                            AppUI.logo();
                            AppUI.Header(AppUI.headerAd(), AppUI.headerName(copieduser), "Texting Admin", AppUI.headerRole(copieduser));
                            Text();
                        }
                        if(choice==8)
                        {
                          LogIn_Handler(userlist);       //This function returns user back to Main screen
                        }
                    }
// Admin Section 

                    else if(copieduser.getrole()=="admin")
                    {
                        MenuUI.Menu(copieduser,"admin");
                        int choice = AppUI.Take_Choice();
                        if(choice==1)
                        {
                            Add_Ajob_inList();          //This Function allows Admin to add a Job in List
                        }
                        if(choice==2)
                        {
                            Remove_aJob_fromList();     //This function allows Admin to remove a Job from List
                        }
                        if(choice==3)
                        {
                            Edit_Job_Detail();          //This Function is used by Admin to edit an exsisting job details
                        }
                        if(choice==4)
                        {
                            JobUI.PrintJobs_List(joblist,copieduser);    //This Function Prints all available Jobs in the List
                        }
                        if(choice==5)
                        {
                            AppUI.logo();
                            AppUI.Header(AppUI.headerAd(), AppUI.headerName(copieduser), "Printing Employees Lists", AppUI.headerRole(copieduser));
                            EmployeeUI.Print_allEmployees(); //Print all available Employees
                        }
                        if(choice==6)
                        {
                            UserUI.Print_allUsers(userlist,copieduser); //Print all users also that haven't appliedin the Job
                        }
                        if(choice==7)
                        {

                            Text();
                        }
                        if (choice == 8)
                        {
                            LogIn_Handler(userlist);
                        }
                    }
                }
            }
        }
        static void LogIn_Handler(UserList userlist)
        {
            MenuUI.DisplayMenu();                           //Displays the Login Menu adn below is the input
            int choice = AppUI.Take_Choice(); 
            while(choice<0&&choice>3)
            {
                choice = AppUI.Take_Choice();
            }
            if (choice == 1)
            {  
                User user = UserUI.Take_credentials();     //Taking User Credentials
                  //Confirming the exsistence of User
                if(Check_LogIns(user,userlist))
                {
                    UserUI.SignUp_result(true);
                    IsUserLoggedIn = true; 
                    copieduser = user;
                    files.storeData(userlist);
                }
                else if(!Check_LogIns(user, userlist))
                {
                    UserUI.SignUp_result(false);
                    IsUserLoggedIn = false;
                }
                return;
            }
            else if (choice == 2)
            {
                User user = UserUI.Take_credentials();
                if (Check_LogIns(user, userlist))         //Checks the exsistence of user for Log In
                {
                    UserUI.SignIn_Failed();
                }
                else
                {
                    files.storeData(userlist);
                    IsUserLoggedIn = true;
                    return;
                }
            }
            else if(choice==3)
            {
                Environment.Exit(0);
            }
            else
            {
                AppUI.ErrorEnterInvalidInput();         //Views Error message for wrong choice
            }
        }
        static bool Check_LogIns(User user,UserList userlist)  //This Function checks the user in the UserLst
        {
          if(!userlist.IsUserExsist(user))              //Verifies that User doesn't exsist already
            {
                userlist.AddUser(user);
                return true;
            }
            if(userlist.IsUserExsist(user))
            {
                return false;
            }
            return false;
        }
       static void Applying_Fora_Job()
        {
            files.loadJobData(joblist);
            employee = JobUI.ApplyFor_aJob(copieduser);          //Views UI to apply for a Job and returns a complete employee
            EmployeeList.Add_anEmployee(employee);     //Adds the returned employee in the List
            AppUI.Halt();
            return;
        }
        static Job Job_InputnReturn()
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), AppUI.headerName(copieduser), "Searching User", AppUI.headerRole(copieduser));
            string job = AppUI.TakeInput("Job Name(Press '0' to return ): ");
            if(job=="0")
            {
                return null;
            }
            Job Found_Job = JobList.Search_thisJob(job);//This Function search the job from job name and returns
            
            while(Found_Job==null&&job!="0")
            {
                AppUI.DisplayError("No such Job.");     //This Function Displays error if job is not found
                job = AppUI.TakeInput("Job Name: ");
            }
            if (Found_Job!=null)
            {
            return Found_Job;
            }
            return null;
        }
       static void Search_for_Job()
       {
            Job Found_Job = Job_InputnReturn();       //This function takes input of a Job Name and returns the Job.
            if(Found_Job==null)
            {
                AppUI.DisplayError(" No Such Job found.");
                return;
            }
            JobUI.Show_Job(Found_Job,copieduser);                //This Functions takes a Job type variable and view the UI of that Job
            AppUI.Halt();
            return;
        }
        static void Make_job_null()
        {
            Job N_job = Job_InputnReturn();
            if(N_job==null)
            {
                return;
            }
            joblist.Remove_Job(N_job);              //This Function takes a Job and remove that job from List
            if(N_job!=null)
            {
             AppUI.Done("Job Removed.");
            }
        }
        static void Replace_myJob(string Job_name)
        {
            bool shifted_Null=JobList.Replace_Myjob(Job_name,employee);//Replace the Job with somwe other exsisting for the employee passed here
            if(shifted_Null==true)
            {
            JobUI.ApplyFor_aJob(copieduser);
            AppUI.Done("Job Replaced.");
            }

            else if(shifted_Null==false)
            {
                AppUI.DisplayError("Couldn't Replaced the Job, no such job found. ");
                AppUI.Halt();
                return;
            }
            AppUI.Halt();
            return;
        }
        static void Add_Ajob_inList()
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), AppUI.headerName(copieduser), "Adding a Job in List", AppUI.headerRole(copieduser));
            Job new_job =JobUI.Add_aNew_Job();    //Views UI to add a new Job in List and returns the new job of Job Type.
            joblist.Add_Job(new_job);            //This Functions adds the new Job in the List of Jobs.
            AppUI.Done("Job Added in List.");
            return;
        }
        static void Remove_aJob_fromList()
        {
            Job Found_Job = Job_InputnReturn();
            if(Found_Job==null)
            {
                return;
            }
            joblist.Remove_Job(Found_Job);      //This function removes the job from Job List.
            AppUI.Done("Job Removed from List.");
            AppUI.Halt();
            return;
        }
        static void Edit_Job_Detail()
        {
            Job Found_Job = Job_InputnReturn();
            if(Found_Job==null)
            {
                return;
            }
            else if(Found_Job!=null)
            {
            AppUI.Done("Enter new Details...");
            JobUI.Edit_thisJob(Found_Job);      //This Function receives a Job type variable and edit the details
            }
        }
        static void View_myJob()
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), AppUI.headerName(copieduser), "Viewing Your Job", AppUI.headerRole(copieduser));
            UserUI.Print_partialEmp_info(employee); //This function prints partial info from Employee List for the user view
            return;
        }
        static void temp_function()
        {
            Job job = new Job("Job1","Khalil Org",2.5f,"lahore","full", 23f);
            Job job2 = new Job("Job2","Khalil Org2",22.5f,"lahore2","part", 2f);
            Job job3 = new Job("Job3","Khalil Org3",23.5f,"lahore3","internship", 3f);
            joblist.Add_Job(job);
            joblist.Add_Job(job2);
            joblist.Add_Job(job3);
        }
        static void Text()
        {
            AppUI.Print_texts();
            string text = AppUI.TakeInput("your message: ");
            TextList.Add_text(text,copieduser.getrole());
            AppUI.Halt();
        }

    }
}
