using System;
using System.Collections.Generic;
using System.Linq;
using TaskManagerApp.Models;

namespace TaskManagerApp.Services
{
    public class TaskManager
    {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        public void AddTask(string title, DateTime dueDate, Priority priority)
        {
            _tasks.Add(new TaskItem(_nextId++, title, dueDate, priority));
        }

        public bool RemoveTask(int id) => _tasks.RemoveAll(t => t.Id == id) > 0;

        public bool UpdateTask(int id, string newTitle, DateTime newDueDate, Priority newPriority)
        {
            var TaskItem = _tasks.FirstOrDefault(t => t.Id == id);
            if (TaskItem == null) return false;
            
            TaskItem.Title = newTitle;
            TaskItem.DueDate = newDueDate;
            TaskItem.Priority = newPriority;
            return true;
        }

        public List<TaskItem> GetAllTasks() => new List<TaskItem>(_tasks);

        public void SortTasksByPriority()
        {
            bool swapped;
            for (int i = 0; i < _tasks.Count - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < _tasks.Count - i - 1; j++)
                {
                    if (_tasks[j].Priority < _tasks[j + 1].Priority)
                    {
                        (_tasks[j], _tasks[j + 1]) = (_tasks[j + 1], _tasks[j]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        public TaskItem BinarySearchByTitle(string title)
        {
            var sortedList = _tasks.OrderBy(t => t.Title).ToList();
            int left = 0, right = sortedList.Count - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(
                    sortedList[mid].Title, 
                    title, 
                    StringComparison.OrdinalIgnoreCase);

                if (comparison == 0) return sortedList[mid];
                if (comparison < 0) left = mid + 1;
                else right = mid - 1;
            }
            return null;
        }
    }
}