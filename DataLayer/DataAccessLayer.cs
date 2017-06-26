using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class DAL 
    {
        public static List<Users> DB=new List<Users>();
    }
    public class Users{
       public string _userName;
        public string _userPassword;
        public  string _userEmail;
        public string _user;

    }
}
