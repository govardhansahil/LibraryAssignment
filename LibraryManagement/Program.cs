using System;
using LogInPage;

namespace LibraryManagement
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            AuthentorSelect AS=new AuthentorSelect();
            int checker;
            do{
                Console.WriteLine("Welcome to the Library!");
                Console.WriteLine("\n\n Select the option from below and click 'ENTER'\n"+"1. User Login \n"+"2. Register\n"+"3. Admin Login\n"+"4. Exit\n");
                int _uiChoice=int.Parse(Console.ReadLine());
               checker= AS.CallChoice(_uiChoice);
                
            }while(checker!=1);
            Console.ReadKey();
        }
    }
}