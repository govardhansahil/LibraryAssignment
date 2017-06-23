using System;

namespace BusinessLayer
{
    public class GetUserData
    {
        public bool CheckuserData(string username, string password){
            if(username=="sahil" && password=="enter")
            return true;
            else return false;
        }
    }
}
