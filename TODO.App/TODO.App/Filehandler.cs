using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TODO_App
{
    public class Filehandler
    {
        public void Print()
        {
            Console.WriteLine("Command line arguments:\n");
            Console.WriteLine("- l   Lists all the tasks\n");
            Console.WriteLine("- a   Adds a new task\n");
            Console.WriteLine("- r   Removes an task\n");
            Console.WriteLine("- c   Completes an task\n");
        }

        public void ReadAll()
        {
            string path = @"D:\greenfox\arvaianett_github_handle-todo-app\tasks.txt";

            string[] file = File.ReadAllLines(path);

            for (int i = 0; i < file.Length; i++)
            {
                file[i] = i + 1 + " - " + file[i];
            }

            foreach (var lines in file)
            {
                Console.WriteLine(lines);
            }
        }

        public void Empty()
        {
            string path = @"D:\greenfox\arvaianett_github_handle-todo-app\tasks.txt";

            string[] file = File.ReadAllLines(path);

            if (file == null)
            {
                Console.WriteLine("No todos for today! :)");
            }
        }

        public void AddNewTask(string input)
        {
            StreamWriter newLine = new StreamWriter(@"D:\greenfox\arvaianett_github_handle-todo-app\tasks.txt");

            newLine.WriteLine(input);

            newLine.Close();
        }

        public void ErrorHandling()
        {
            Console.WriteLine("Unable to add: no task provided");
        }

        //public void Remove(int input)
        //{
        //    string[] array = File.ReadAllLines(@"D:\greenfox\arvaianett_github_handle-todo-app\tasks.txt");

        //    array[input + 1] = null;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] != null)
        //        {
        //            //(@"D:\greenfox\arvaianett_github_handle-todo-app\tasks.txt");
        //        }
        //    }
        //}
    }
}
