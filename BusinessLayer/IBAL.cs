namespace BusinessLayer
{
    public interface IAuthentorBAL{
        void UserLogIn();
        void AdminLogIn();
        void Register();

    }
    public interface IAuthentorSelectBAL{

        int CallChoice(int a);
    }
    public interface ICredentialCheckBAL{
        bool CheckUserData(string username, string password);
        bool CheckAdminData(string  username, string password);
    }

}