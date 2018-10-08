using System;

namespace ex7
{
    class Program
    {
        // declaring the delegate
        public delegate void Notifier(string name);

        static void Main(string[] args)
        {
            // creating a variable to hold the delegate
            Notifier caller = sayHello;
            caller += sayGoodbye;

            // using the delegate
            caller("Albert");
        }

        // creating methods compatible with the Notifier delegate
        public static void sayHello(string name)
        {
            System.Console.WriteLine( $"Hello {name}" );
        }

        public static void sayGoodbye(string name)
        {
            System.Console.WriteLine( $"Goodbye {name}" );
        }
    }
}
