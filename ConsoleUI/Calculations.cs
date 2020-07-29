using System;
using System.Collections.Generic;
using System.Text;

namespace _1ConsoleUI
{
    class Calculations
    {
        public static void CalculateDoubleValue(string message)
        {
            bool isDouble;
            double convertedUserNumber;
            do
            {
                string userNumber = RequestData.GetUserInput(message);
                isDouble = double.TryParse(userNumber, out convertedUserNumber);
                if (isDouble == false)
                {
                    Console.WriteLine("Please Try again");
                }

            } while (isDouble == false);

            Console.WriteLine($"The double of {convertedUserNumber} is {convertedUserNumber * 2}");
        }
    }
}
