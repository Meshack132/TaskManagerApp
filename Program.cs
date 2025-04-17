using System;
using TaskManagerApp.Models;
using TaskManagerApp.Services;
using TaskManagerApp.Utilities;

namespace TaskManagerApp
{
    class Program
    {
        static readonly TaskManager manager = new TaskManager();

        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleHelper.DisplayMenu();
                HandleInput(Console.ReadLine());
            }
        }

        static void HandleInput(string choice)
        {
            switch (choice)
            {
                case "1":
                    AddTaskFlow();
                    break;
                case "2":
                    RemoveTaskFlow();
                    break;
                // Other case handlers...
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }

        static void AddTaskFlow()
        {
            // Input collection and validation logic
        }

        static void RemoveTaskFlow()
        {
            // TaskItem removal logic
        }

        // Other workflow methods...
    }
}