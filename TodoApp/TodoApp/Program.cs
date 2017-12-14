using System;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var text in args)
            {
                Console.WriteLine(text);
            }

            if (args.Length == 0)
            {
                Console.WriteLine("Command line arguments:");
                Console.WriteLine("- l   Lists all the tasks");
                Console.WriteLine("- a   Adds a new task");
                Console.WriteLine("- r   Removes an task");
                Console.WriteLine("- c   Completes an task");
            }
        }
    }
}
