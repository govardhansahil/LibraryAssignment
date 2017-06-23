using System;
using BusinessLayer;

namespace LogInPage
{
    public class Authentor
    {
        GetUserData verify=new GetUserData();       
        public void UserLogIn(){
            bool x;
            do{
            Console.WriteLine("Type Username:");
            string username=Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password=Console.ReadLine();
            if(x=verify.CheckuserData(username, password)){
                Console.WriteLine("-----WELCOME to LIBRARY-----");

            }
            else Console.WriteLine("Invalid Login Credentials!");
            }while(x!=true);

        }

        public void AdminLogIn(){
            
            Console.WriteLine("Type Admin username:");
            Console.ReadLine();
            Console.WriteLine("Enter Admin Password:");
            Console.ReadLine();

            Console.WriteLine("ADMIN Params sent to BL");
        }
        public void Register(){


        }
    }
    public class AuthentorSelect{
        public int CallChoice(int choice){
            Authentor obj=new Authentor();
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
