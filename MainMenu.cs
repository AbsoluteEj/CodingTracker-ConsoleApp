using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker_ConsoleApp
{
    class MainMenu
    {
        // Create method for showing menu
        public void ShowMenu()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            bool isRunning = true;

            while (isRunning == true)
            {
                Console.WriteLine("Track your progress. Be Consistent!");
                Console.WriteLine("Choose from the options below:\n");
                Console.WriteLine("Type 0 to close the application");
                Console.WriteLine("Type 1 to view all previous records");
                Console.WriteLine("Type 2 to insert/create a record");
                Console.WriteLine("Type 3 to update a record");
                Console.WriteLine("Type 4 to delete a record");
                
                string userInput = Console.ReadLine();

                switch (userInput.Trim())
                {
                    case "0":
                        Console.WriteLine("Thank you for using!");
                        isRunning = false;
                        break;
                    case "1":
                        // some method
                        break;
                    case "2":
                        // some method
                        break;
                    case "3":
                        // some method
                        break;
                    case "4":
                        // some method
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        // can have method here that redirects to the 'select options' again
                        break;
                }
            }

        }
    }
}
