namespace TaskManagerApp.Models
{
    public class TaskItem
    {
        public int Id { get; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }

        public TaskItem(int id, string title, DateTime dueDate, Priority priority)
        {
            Id = id;
            Title = title;
            DueDate = dueDate;
            Priority = priority;
        }
    }
}