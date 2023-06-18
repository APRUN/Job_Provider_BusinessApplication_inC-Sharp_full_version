using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job_Provider_BusinessApplication_inC_Sharp_full_version.BL;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.DL
{
    class UserList
    {
        private List<User> users = new List<User>();
        public List<User> get_userList()
        {
            return users;
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public bool IsUserExsist(User user)
        {
            foreach(User tempuser in users)
            {
                if(tempuser.getname()==user.getname())
                {
                    return true;
                }
            }
            return false;
        }
        public User Search_User(User user)
        {
            foreach (User tempuser in users)
            {
                if (tempuser.getname() == user.getname())
                {
                    if(tempuser.getpassword()==user.getpassword())
                    {
                    return tempuser;
                    }
                }
            }
            return null;
        }
        public bool Valid_Credentials(User user)
        {
            foreach (User tempuser in users)
            {
                if (tempuser.getname() == user.getname())
                {
                    if(tempuser.getpassword()==user.getpassword())
                    {
                    return true;
                    }
                }
            }
            return false;
        }
    }
}
