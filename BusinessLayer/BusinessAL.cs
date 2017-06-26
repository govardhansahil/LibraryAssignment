using DataLayer;
using System;

namespace BusinessLayer
{
    public class GetUserData : ICredentialCheckBAL
    {
        Users UDB=new Users();
        public bool CheckUserData(string username, string password){
            if(username==UDB._userName && password==UDB._userPassword)
            return true;
            else return false;
        }

        public bool CheckAdminData(string username, string password){
            if(username=="admin" && password=="admin") return true;
            else return false;

        }
        public void InsertUserData(string userName, string email, string user, string Password){
            UDB._user=user;
            Console.WriteLine(UDB._user);
            UDB._userName=userName;
            Console.WriteLine(UDB._userName);
            UDB._userEmail=email;
            Console.WriteLine(UDB._userEmail);
            UDB._userPassword=Password;
            Console.WriteLine(UDB._userPassword);
            DAL.DB.Add(UDB);

            foreach (var item in DAL.DB)
            {
                Console.WriteLine(item);
            }
        }

    }
}
