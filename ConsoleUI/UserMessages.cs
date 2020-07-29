using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace _1ConsoleUI
{
   public static class UserMessages
    {
        
       public static void ApplicationStartMessage(string name)
        {
            string message = $"Welcome to my App {name}";
            int now = DateTime.Now.Hour;
            if(now < 12)
            {
                Console.WriteLine($"Goodmorning! {message}");
            }
            else
            {
                Console.WriteLine($"GoodAfternoon! {message}");
            }
        }

        public static void PrintFinalMessage(string name)
        {
            Console.WriteLine($"Thank you for using my app {name}");
            Console.WriteLine("Have a nice day");
        }

      
    }

}
