using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter some integers: ");
            // int values = Convert.ToInt32(Console.ReadLine());

            // var addMethod = new Calculator(); 
            // addMethod.AddParams();
            // Was trying to use input for single numbers, array would be hardcoded.

            var addMethod = new Calculator();
            addMethod.AddParams(1, 2, 3);

            int[] array = {4, 5, 6, 7};
            var addArray = new Calculator();
            addArray.AddParams(array);
        }
    }
}
