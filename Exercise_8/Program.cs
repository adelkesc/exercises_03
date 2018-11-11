using System;

namespace Exercise_8
{
    class Program
    {
        public delegate void Notifier(string str); // Declare the delegate

        public static void SayHello(string name) // Create methods for the delegate
        {
            Console.WriteLine("Hello " + name);
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }

        public static void Main(string[] args)
        {
            Notifier speak = SayHello; // Instantiate the delegate.
            speak("Andrea"); // Call the delegate

            Notifier speak2 = SayGoodbye;
            speak2("Andrea");
        }
    }
    // Why do the methods need static?  Are they always required?
    // Why can't I call the delegate from a separate class?
}
