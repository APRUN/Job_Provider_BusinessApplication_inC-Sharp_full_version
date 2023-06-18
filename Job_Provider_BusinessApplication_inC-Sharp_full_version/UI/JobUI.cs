using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.BL;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.DL;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.UI
{
    class JobUI
    {
        public static void NoSuch_JobFound()
        {
            AppUI.DisplayError("Job not Found.");
        }
        public static void JobAlready_Exsist()
        {
            AppUI.DisplayError("Job Already Exsist.");
        }
        public static string TakeEmp_Name()
        {
            return AppUI.TakeInput("Your Name: ");
        }
        public static string TakeEmp_Contact()
        {
            return AppUI.TakeInput("Your Contact: ");
        }
        public static int TakeEmp_Age()
        {
           return AppUI.TakeInput("Your Age: ","int");
        }
        public static string TakeEmp_City()
        {
            return AppUI.TakeInput("Your City");
        }
        public static string TakeEmp_CNIC()
        {
            return AppUI.TakeInput("Your CNIC: ");
        }
        public static string TakeJob_Name()
        {
           return AppUI.TakeInput("Job Name: ");
        }
        public static string TakeCompany_Name()
        {
            return AppUI.TakeInput("Company Name: ");
        }
       
        public static Employee ApplyFor_aJob(User user)
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), AppUI.headerName(user), "Applying for a Job", AppUI.headerRole(user));
            string name = AppUI.TakeInput("Your Name: ");
            string contact = AppUI.TakeInput("Your Contact: ");
            float age = AppUI.TakeInput("Your Age: ",2.3f);
            string city = AppUI.TakeInput("Your City: ");
            string cnic = AppUI.TakeInput("Your CNIC: ");
            string jobname = AppUI.TakeInput("Job Name: ");
            while (!JobList.Search_thisJob_bool(jobname))
            {
                jobname = AppUI.TakeInput("Job name again(0. Return): ");
                if(jobname=="0")
                {
                    return null;
                }
                      
            }
            float experience = AppUI.TakeInput("Your Experience: ",2.3f);
            string category = AppUI.TakeInput(" Job Category(full/part/internship): ");
            while(category!="full"&&category!="part"&&category!="internship")
            {
                category = AppUI.TakeInput(" Job Category Again(full/part/internship): ");
            }
            if(JobList.Search_thisJob_bool(jobname))
            {
            Employee employee=new Employee(name,age,contact,city,cnic,jobname,experience,category);
            return employee;
            }
            return null;
        }
        public static Job Add_aNew_Job()
        {
            string category = AppUI.TakeInput(" Job Category(full/part/internship): ");
            while(category!="part"&&category!="full"&&category!="internship")
            {
                category = AppUI.TakeInput(" Job Category(full/part/internship): ");
            }
            string name = AppUI.TakeInput("Job Name: ");
            string company_name = AppUI.TakeInput("Company Name: ");
            string locality = AppUI.TakeInput("City Name: ");
            float experience = AppUI.TakeInput("Experience needed For Job: ",2.3f);
            float pay = AppUI.TakeInput("Pay for the Job: ",2.3f); 
            if(category=="full")
            {
            Full_Time job = new Full_Time(name, company_name, experience, locality,category, pay);
                return job;
            }
            else if(category=="part")
            {
                PartTime job = new PartTime(name, company_name, experience, locality, category, pay);
                return job;
            }
            else if(category=="internship")
            {
                Internship job = new Internship(name, company_name, experience, locality, category,pay);
                return job;
            }
            return null;
        }
        public static void PrintJobs_List(JobList joblist,User user)
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), AppUI.headerName(user), "Printing Job Lists", AppUI.headerRole(user));
            Console.WriteLine("Job Name\t   Location\t  Company Name\t   Min Experience\t  Category\t  Pay");
            foreach(var s in joblist.getJobs())
            {
                Console.WriteLine(s.getjobname()+"\t\t\t"+s.Get_City()+ "\t\t\t" + s.Get_Company_Name()+ "\t\t\t" + s.Get_experiencefor()+ "\t\t\t" + s.getcategory()+"\t\t"+s.getpay());
            }
            Console.ReadKey();
            return;
        }
        public static void Show_Job(Job job,User user)
        {
            AppUI.logo();
            AppUI.Header(AppUI.headerAd(), AppUI.headerName(user), "Viewing a Job", AppUI.headerRole(user));
            Console.WriteLine("Job Name: " + job.getjobname());
            Console.WriteLine("Company Name: " + job.Get_Company_Name());
            Console.WriteLine("Job Area: " + job.Get_City());
            Console.WriteLine("Needed Experience: " + job.Get_experiencefor());
            Console.WriteLine("Category: "+job.getcategory());
            Console.WriteLine("Pay: "+job.getpay());
            AppUI.Halt();
            return;
        }
        public static Job Edit_thisJob(Job job)
        {
            job.setname(AppUI.TakeInput("New Name: "));
            job.set_companyname(AppUI.TakeInput("New Company Name: "));
            job.set_city(AppUI.TakeInput("New City Name: "));
            job.set_experience(AppUI.TakeInput("New Experience: ",2.3f));
            job.setcategory(AppUI.TakeInput("New Category(full/part/internship): "));
            job.setpay(AppUI.TakeInput("Neutral Pay for the job: ",2.3f));
            return job;

        }

    }
}
