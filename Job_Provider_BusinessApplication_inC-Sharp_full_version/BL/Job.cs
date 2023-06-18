using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.BL
{
    class Job
    {
        private string job_name;
        private string companyname;
        private float experiencefor;
        private string city;
        private string category;
        protected float pay;
        public Job()
        {

        }

        public Job(string job_name, string companyname, float experiencefor, string city,string category,float pay)
        {
            this.job_name = job_name;
            this.companyname = companyname;
            this.experiencefor = experiencefor;
            this.city = city;
            this.category = category;
            this.pay = pay;
        }
        public string getjobname()
        {
            return job_name;
        }
        public string Get_Company_Name()
        {
            return companyname;
        }
        public string Get_City()
        {
            return city;
        }
        public float Get_experiencefor()
        {
            return experiencefor;
        }
        public void setname(string job_name)
        {
            this.job_name = job_name;
        }
        public void set_companyname(string companyname)
        {
            this.companyname = companyname;
        }
        public void set_city(string city)
        {
            this.city = city;
        }
        public void set_experience(float experiencefor)
        {
            this.experiencefor = experiencefor;
        }
        public string getcategory()
        {
            return category;
        }
        public void setcategory(string category)
        {
            this.category = category;
        }
        public void setpay(float pay)
        {
            this.pay = pay;
        }
        public virtual void Setpay(float pay, float age)
        {
            age = (age / 10);
            age = age * 1000;
            pay = pay + age;
        }
        public float getpay()
        {
            return pay;
        }
    }
}
