using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.DL;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.BL
{
    class FileManagement
    {

        public FileManagement()
        {

        }

        public void storeData(UserList userList)
        {
            string path = "C:\\Users\\OGGY\\Source\\Repos\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\userdata.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (var i in userList.get_userList())
            {
                file.WriteLine(i.getname() + "," + i.getpassword() + "," + i.getrole());
            }
            file.Flush();
            file.Close();
        }
        public void loadData(UserList userList)
        {
            string path = "C:\\Users\\OGGY\\Source\\Repos\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\userdata.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                User user = new User(word[0], word[1], word[2]);
                userList.AddUser(user);
            }
            file.Close();
        }
        public void storeJobData(JobList jobList)
        {
            string path = "C:\\Users\\OGGY\\Source\\Repos\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Jobdata.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (var i in jobList.getJobs())
            {
                file.WriteLine(i.getjobname() + "," + i.Get_Company_Name()+","+i.Get_experiencefor() + "," + i.Get_City() + ","+i.getcategory()+","+i.getpay());
            }
            file.Flush();
            file.Close();
        }
        public void loadJobData(JobList jobList)
        {
            string path = "C:\\Users\\OGGY\\Source\\Repos\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Jobdata.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                Job job = new Job(word[0],word[1],float.Parse(word[2]), word[3],word[4],float.Parse(word[5]));
                jobList.Add_Job(job);
            }
            file.Close();
        }
        public void storeEmpData()
        {
            string path = "C:\\Users\\OGGY\\Source\\Repos\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Employeedata.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (var i in EmployeeList.getEmployee_list())
            {
                file.WriteLine(i.get_AppliedEmp_JobName() + "," + i.get_appliedEmp_age() + "," + i.get_EmployeeContact() + "," + i.get_EmployeeLocality() + "," + i.get_appliedEmp_cnic() + "," + i.get_AppliedEmp_JobName()+","+i.get_appliedEmp_jobExp()+","+i.get_appliedEmpJob_category());
            }
            file.Flush();
            file.Close();
        }
        public void loadEmpData()
        {
            string path = "C:\\Users\\OGGY\\Source\\Repos\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Job_Provider_BusinessApplication_inC-Sharp_full_version\\Employeedata.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                Job job = new Job(word[0], word[1], float.Parse(word[2]), word[3], word[4], float.Parse(word[5]));
                Employee employee = new Employee(word[0], float.Parse(word[1]), word[2], word[3], word[4], word[5],float.Parse(word[6]),word[7]);
                EmployeeList.Add_anEmployee(employee);
            }
            file.Close();
        }
    }
}
