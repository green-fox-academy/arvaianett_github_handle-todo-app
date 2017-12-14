using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TODO_App
{
    class Filehandler
    {
        public List<string> ReadAll()
        {
            string path1 = @"D:\greenfox\arvaianett_github_handle-todo-app\ListTasks\dog.txt";
            string path2 = @"D:\greenfox\arvaianett_github_handle-todo-app\ListTasks\milk.txt";
            string path3 = @"D:\greenfox\arvaianett_github_handle-todo-app\ListTasks\homework.txt";


            string file1 = File.ReadAllText(path1);
            string file2 = File.ReadAllText(path2);
            string file3 = File.ReadAllText(path3);

            var list = new List<string>() { file1, file2, file3 };

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = i + 1 + " - " + list[i];
            }

            return list;
        }
    }
}
