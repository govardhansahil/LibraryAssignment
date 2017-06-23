using System;
using BusinessLayer;

namespace LogInPage
{
    public class Authentor : IAuthentorBAL
    {
        bool x;
        ICredentialCheckBAL verify=new GetUserData();       
        public void UserLogIn(){
            do{
            Console.WriteLine("Type Username:");
            string username=Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password=Console.ReadLine();
            if(x=verify.CheckUserData(username, password)){
                Console.WriteLine("-----WELCOME to LIBRARY-----");

            }
            else Console.WriteLine("Invalid Login Credentials!");
            }while(x!=true);

        }

        public void AdminLogIn(){
            do{
            Console.WriteLine("Type Admin username:");
            string username=Console.ReadLine();
            Console.WriteLine("Enter Admin Password:");
            string password=Console.ReadLine();
            if(x=verify.CheckAdminData(username,password))
            Console.WriteLine("Logged in as ADMIN");

            }while(x!=true);
        }
        public void Register(){


        }
    }
    public class AuthentorSelect : IAuthentorSelectBAL
    {
        public int CallChoice(int choice){
            IAuthentorBAL obj=new Authentor();
            switch (choice) {
                    case 1:
                        obj.UserLogIn();
                        break;
                    case 2:
                        obj.Register();
                        break;
                    case 3:
                        obj.AdminLogIn();
                        break;
                    case 4:
                        Console.WriteLine("Thank you!");
                        return 1;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                return 0;

        }

    }
}
