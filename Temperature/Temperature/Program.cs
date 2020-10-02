using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Ask user to input temperature
                double temperature = InputDouble("Enter your temperature (C): ");
                // Ask user for other symptoms
                bool cough = InputBool("Do you have a dry cough? (y/n): ");
                bool smell = InputBool("Do you have a loss of smell? (y/n): ");
                bool taste = InputBool("Do you have a loss of taste? (y/n): ");

                Console.WriteLine();
                // If there's a symptom, must isolate for 14 days
                if ((temperature > 37.2) || (taste == true) || (smell == true) || (cough == true))
                {
                    Console.WriteLine("You must self isolate for 14 days D:");
                }
                else
                {
                    Console.WriteLine("You do not have symptoms!");
                }

                Console.WriteLine();
            }
        }

        // Ask user for a y/n input
        static bool InputBool (string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter \"y\" or \"n\".");
                    Console.WriteLine();
                }
            }
        }

        // Ask user for a decimal input
        static double InputDouble (string message)
        {
            double temp = 0.0;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    temp = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                    Console.WriteLine();
                }
                if ((temp >= 20) && (temp <= 50))
                {
                    return temp;
                }
            }
            
        }
    }
}
