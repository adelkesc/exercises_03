using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring the objects and their values in one line.
            Time Time1 = new Time{Hours = 3, Minutes = 30};  
            Time Time2 = new Time{Hours = 2, Minutes = 45};

            // Declaring a third empty object to hold the result.
            Time Time3 = new Time();

            // Adding the objects together using the overloaded operator.
            Time3 = Time1 + Time2;
            
            // Creating a variable of type string to hold the result of the ToString() method.
            string finalTime = Time3.ToString();

            Console.WriteLine(finalTime);
        }
    }
}
