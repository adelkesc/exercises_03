using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bomb b1 = new Bomb();     
            
            Console.WriteLine(b1.Explode(4.0));
        }
    }
}
