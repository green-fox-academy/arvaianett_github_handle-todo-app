using System;

namespace TODO_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Filehandler filehandler = new Filehandler();

            if (args.Length == 0)
            {
                filehandler.Print();
            }

            else if (args[0] == "-l")
            {
                filehandler.ReadAll();
                filehandler.Empty();
            }

            else if (args[0] == "-a")
            {
                string input = Console.ReadLine();

                try
                {
                    filehandler.AddNewTask(input);
                }
                catch
                {
                    filehandler.ErrorHandling();
                }
            }

            //else if (args[0] == "-r")
            //{
            //    int input = int.Parse(Console.ReadLine());

            //    try
            //    {
            //        filehandler.Remove(input);
            //    }
            //    catch ()

            //}


            //    Console.ReadLine();

        }
    }
}
