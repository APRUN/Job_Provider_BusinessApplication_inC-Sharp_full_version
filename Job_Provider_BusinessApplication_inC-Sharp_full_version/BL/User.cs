using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.BL
{
    class User
    {
        protected string name;
        protected string password;
        protected string role;
        public User()
        {

        }
        public User(string name,string password,string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setpassword(string password)
        {
            this.password = password;
        }
        public void setrole(string role)
        {
            this.role = role;
        }
        public string getname()
        {
            return name;
        }
        public string getpassword()
        {
            return password;
        }
        public string getrole()
        {
            return role;
        }


    }
}
