using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.BL
{
    class Full_Time:Job
    {
        public Full_Time(string name, string companyname, float experience, string city,string Jobcategory, float pay) : base(name, companyname, experience, city,Jobcategory,pay)
        {

        }
        public override void Setpay(float pay, float age)
        {
            while (age > 10)
            {
                age = age / 10;
            }
            age = age * 1000;
            pay = pay + age;
        }
        public float Getpay()
        {
            return pay;
        }
    }
}
