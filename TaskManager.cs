using System;
using System.Collections.Generic;
using System.Linq;

namespace Individual_project
{
    internal class TaskManager
    {
        public List<Task> Tasks { get; set; } = new List<Task>();

        public void AddTask(string title, DateTime dueDate, string project)
        {
            Tasks.Add(new Task(title, dueDate, project));
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < Tasks.Count)
            {
                Tasks.RemoveAt(index);
            }
        }

        public void MarkTaskAsDone(int index)
        {
            if (index >= 0 && index < Tasks.Count)
            {
                Tasks[index].IsDone = true;
            }
        }

        public List<Task> GetTasksSortedByDate()
        {
            return Tasks.OrderBy(t => t.DueDate).ToList();
        }

        public List<Task> GetTasksSortedByProject()
        {
            return Tasks.OrderBy(t => t.Project).ToList();
        }
    }
}
