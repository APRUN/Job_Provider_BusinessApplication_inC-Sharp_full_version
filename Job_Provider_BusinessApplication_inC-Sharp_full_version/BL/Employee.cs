using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.BL
{
    class Employee
    {
        private string name;
        private string city;
        private string contact;
        private float age;
        private string cnic;
        private string jobname;
        private float experience;
        private string Jobcategory;
        public Employee()
        {

        }
        public Employee(string name,float age, string contact, string city,string cnic, string jobname,float experience,string Jobcategory)
        {
            this.name = name;
            this.age = age;
            this.contact = contact;
            this.city = city;
            this.cnic = cnic;
            this.jobname = jobname;
            this.experience = experience;
            this.Jobcategory = Jobcategory;
        }
        public string get_AppliedEmp_name()
        {
            return name;
        }
        public float get_appliedEmp_age()
        {
            return age;
        }
        public string get_appliedEmp_cnic()
        {
            return cnic;
        }
        public string get_AppliedEmp_JobName()
        {
            return jobname;
        }
        public string get_EmployeeContact()
        {
            return contact;
        }
        public string get_EmployeeLocality()
        {
            return city;
        }
        public string get_appliedEmpJob_category()
        {
            return Jobcategory;
        }
        public float get_appliedEmp_jobExp()
        {
            return experience;
        }
        public void set_AppliedEmp_JobName(string job)
        {
            jobname = job;
        }
        public void set_empJobCategory(string Jobcategory)
        {
            this.Jobcategory = Jobcategory;
        }
        public string tostring()
        {
            return (get_AppliedEmp_name()+get_EmployeeContact()+get_EmployeeLocality()+get_AppliedEmp_JobName()+get_appliedEmpJob_category());
        }
    }
}
