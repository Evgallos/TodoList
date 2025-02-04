using System;
using System.Collections.Generic;
using static System.Console;

enum UserChoice
{
    AddTask = 1,
    DeleteTask,
    Exit
}

class Program
{
    static void Main(string[] args)
    {
        List<string> TOdoList = new List<string>();

        while (true)
        {
            WriteLine("To-do List:");
            for (int i = 0; i < TOdoList.Count; i++)
            {
                WriteLine($"({i + 1}) {TOdoList[i]}");
            }

            WriteLine("\n1. Add Task");
            WriteLine("2. Delete Task");
            WriteLine("3. Exit");
            WriteLine("Enter your choice:");

            int choice;
            if (!int.TryParse(ReadLine(), out choice) || !Enum.IsDefined(typeof(UserChoice), choice))
            {
                WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                continue;
            }

            if (choice == (int)UserChoice.AddTask)
            {
                WriteLine("Enter Task: ");
                string task = ReadLine();
                TOdoList.Add(task);
                Clear();
                WriteLine("Task added successfully");
            }
            else if (choice == (int)UserChoice.DeleteTask)
            {
                if (TOdoList.Count == 0)
                {
                    WriteLine("You currently have no tasks in your To-do list.");
                    continue;
                }

                WriteLine("Enter the number of the task you want to delete:");
                int taskNum;
                if (!int.TryParse(ReadLine(), out taskNum) || taskNum <= 0 || taskNum > TOdoList.Count)
                {
                    WriteLine("Invalid task number.");
                    continue;
                }

                TOdoList.RemoveAt(taskNum - 1);
                Clear();
                WriteLine("Task deleted successfully!");
            }
            else if (choice == (int)UserChoice.Exit)
            {
                break;
            }

            ReadKey();
            Clear();
        }
    }
}