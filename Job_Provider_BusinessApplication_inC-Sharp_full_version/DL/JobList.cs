using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.BL;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.DL
{
    class JobList
    {
        private static List<Job> jobs = new List<Job>();
        public List<Job> getJobs()
        {
            return jobs;
        }
        public void Remove_Job(Job job)
        {
            jobs.Remove(job);
        }
        public void Add_Job(Job job)
        {
            jobs.Add(job);
        }
        public static Job Search_thisJob(string job)
        {
            foreach(Job tempjob in jobs)
            {
                if(tempjob.getjobname()==job)
                {
                    return tempjob;
                }
            }
            return null;
        }
        public static bool Search_thisJob_bool(string job)
        {
            foreach (Job tempjob in jobs)
            {
                if (tempjob.getjobname() == job)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Replace_Myjob(string old_name, Employee emp)
        {

            if (old_name == emp.get_AppliedEmp_JobName())
            {
                return true;
            }

            return false;
        }


    }
}
