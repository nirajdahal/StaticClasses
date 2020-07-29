using System;
using System.Collections.Generic;
using System.Text;

namespace _1ConsoleUI
{
    class RequestData
    {
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
            ;
        }
        
    }
}
