using System;

namespace TODO_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Filehandler filehandler = new Filehandler();

            //foreach (var lines in filehandler.ReadAll())
            //{
            //    Console.WriteLine(lines);
            //}
            //Console.ReadLine();

            foreach (var argument in args)
            {
                //Console.WriteLine(argument);
                if (args.Length == 0)
                {
                    Console.WriteLine("Command line arguments:");
                    Console.WriteLine("- l   Lists all the tasks");
                    Console.WriteLine("- a   Adds a new task");
                    Console.WriteLine("- r   Removes an task");
                    Console.WriteLine("- c   Completes an task");
                }
                else if (argument == "-l")
                {
                    foreach (var lines in filehandler.ReadAll())
                    {
                        Console.WriteLine(lines);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
