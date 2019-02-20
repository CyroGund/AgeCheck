using System;

namespace checkage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Process ();
            Console.ReadKey();

        }

        private static void Process()
        {
            int Age;
            Console.WriteLine("Inform your age: ");
            int.TryParse(Console.ReadLine(), out Age);

            if ( Age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Access Allowed");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Access Denied");
            }
        }
    }
}
