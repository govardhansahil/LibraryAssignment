using System;

namespace BusinessLayer
{
    public class GetUserData : ICredentialCheckBAL
    {
        public bool CheckUserData(string username, string password){
            if(username=="sahil" && password=="enter")
            return true;
            else return false;
        }

        public bool CheckAdminData(string username, string password){
            if(username=="admin" && password=="admin") return true;
            else return false;

        }
    }
}
