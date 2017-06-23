<<<<<<< HEAD
﻿using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
=======
﻿using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _authenstatus=true;
            while(_authenstatus){
                Console.WriteLine("\n\n Select the option from below and click 'ENTER'\n\n"+"1. User Login \n"+"2. Register\n"+"3. Admin Login\n"+"4. Exit\n");
                int _uiChoice=int.Parse(Console.ReadLine());
                switch (_uiChoice) {
                    case 1:
                        Console.WriteLine("Selected Login");
                        break;
                    case 2:
                        Console.WriteLine("Selected Registration");
                        break;
                    case 3:
                        Console.WriteLine("Selected Admin login");
                        break;
                    case 4:
                        Console.WriteLine("Thank you!");
                        _authenstatus=false;
                         break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
>>>>>>> master
