using System;
using static System.Int32;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter case (-1 to exit): ");
                var userInput = Console.ReadLine();
                TryParse(userInput, out var selection);

                if (selection > 0)
                {
                    switch (selection)
                    {
                        case 1:
                            BasicProblems.MyMethod1();
                            break;
                        case 2:
                            BasicProblems.MyMethod2();
                            break;
                        default:
                            Console.WriteLine("Nothing to do.");
                            break;
                    }
                }
                else if (selection == -1)
                {
                    Console.WriteLine("Exiting. Bye!");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
