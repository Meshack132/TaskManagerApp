using System;
using TaskManagerApp.Models;
using TaskManagerApp.Services;

namespace TaskManagerApp.Utilities
{
    public static class ConsoleHelper
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("\nTask Manager App");
            Console.WriteLine("1. Add TaskItem");
            Console.WriteLine("2. Remove TaskItem");
            Console.WriteLine("3. Update TaskItem");
            Console.WriteLine("4. List All Tasks");
            Console.WriteLine("5. Sort Tasks by Priority");
            Console.WriteLine("6. Search TaskItem by Title");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
        }

        public static void DisplayTasks(List<TaskItem> tasks)
        {
            Console.WriteLine("\nTasks:");
            foreach (var TaskItem in tasks)
            {
                Console.WriteLine($"ID: {TaskItem.Id} | " +
                    $"Title: {TaskItem.Title,-20} | " +
                    $"Due: {TaskItem.DueDate:yyyy-MM-dd} | " +
                    $"Priority: {TaskItem.Priority}");
            }
        }

        // Other helper methods for input handling...
    }
}