using System;

namespace Exercise_7
{
    public class Calculator
    {
        public void AddParams(params int[] values)
        {
            int sum = 0;

            foreach(int number in values)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
        // Params can take multiple arguments but do more research before attempting (arg 1, arg 2).
        // Try testing by making the params method static if you get the chance.
    }
}