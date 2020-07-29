using System;
using System.Runtime.CompilerServices;

namespace _1ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string askName = RequestData.GetUserInput("What is your name ?");
 
            UserMessages.ApplicationStartMessage(askName);

            Calculations.CalculateDoubleValue("Enter a number:");

                UserMessages.PrintFinalMessage(askName);


        }


    }


}
