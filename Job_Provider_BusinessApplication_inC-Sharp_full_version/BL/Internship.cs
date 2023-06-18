using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.BL
{
    class Internship:Job
    {
        public Internship(string name, string companyname, float experience, string city,string Jobcategory, float pay) : base(name, companyname, experience, city, Jobcategory,pay)
        {

        }
        public override void Setpay(float pay, float duration)
        {
            while (duration > 10)
            {
                duration = duration / 10;
            }
            duration = duration * 1000;
            pay = pay + duration;
        }
        public float Getpay()
        {
            return pay;
        }
    }
}
