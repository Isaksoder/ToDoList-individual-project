using System;

namespace Individual_project
{
    internal class Task
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
        public string Project { get; set; }

        public Task(string title, DateTime dueDate, string project)
        {
            Title = title;
            DueDate = dueDate;
            IsDone = false; // Default to not done
            Project = project;
        }

        public override string ToString()
        {
            return $"{(IsDone ? "[Done]" : "[Pending]")} {Title} (Due: {DueDate:yyyy-MM-dd}, Project: {Project})";
        }
    }
}
