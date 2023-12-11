using System;

namespace WhileLoops_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type your Name");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: " + input);
            }

            Console.WriteLine("Loop ended.");

            // Uncomment the following code to see the while loop in action

            // var i = 0;
            // while (i <= 10)
            // {
            //     if (i % 2 == 0)
            //         Console.WriteLine(i);
            //
            //     i++;
            // }
        }
    }
}
