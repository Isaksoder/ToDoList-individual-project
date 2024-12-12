using Individual_project;
using System;

namespace Individual_project
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            // Load tasks from file
            FileHandler.Load(taskManager);

            while (true)
            {
                ShowMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewTasks(taskManager);
                        break;
                    case "2":
                        AddTask(taskManager);
                        break;
                    case "3":
                        MarkTaskAsDone(taskManager);
                        break;
                    case "4":
                        RemoveTask(taskManager);
                        break;
                    case "5":
                        FileHandler.Save(taskManager);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tasks saved. Goodbye!");
                        Console.ResetColor();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine(new string('-', 50));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===== To-Do List Menu =====");
            Console.ResetColor();
            Console.WriteLine("1. View all tasks");
            Console.WriteLine("2. Add a task");
            Console.WriteLine("3. Mark task as done");
            Console.WriteLine("4. Remove a task");
            Console.WriteLine("5. Save and Quit");
            Console.WriteLine(new string('-', 50));
            Console.Write("Choose an option: ");
        }

        static void ViewTasks(TaskManager taskManager)
        {
            if (taskManager.Tasks.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No tasks to display.");
                return;
            }

            Console.WriteLine("\nTasks:");
            Console.WriteLine(new string('-', 50)); //Divider line
            int index = 1;
            foreach (var task in taskManager.Tasks)
            {
                // Set color based on task status
                if (task.IsDone)
                {
                    Console.ForegroundColor = ConsoleColor.Green;  // Green for completed tasks
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;  // Yellow for pending tasks
                }
                
                Console.WriteLine($"{index}. {task}");
                index++;

                // Reset color after each task
                Console.ResetColor();
            }
        }

        static void AddTask(TaskManager taskManager)
        {
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();

            Console.Write("Enter due date (yyyy-MM-dd): ");
            DateTime dueDate;
            while (!DateTime.TryParse(Console.ReadLine(), out dueDate))
            {
                Console.Write("Invalid date. Enter again (yyyy-MM-dd): ");
            }

            Console.Write("Enter project name: ");
            string project = Console.ReadLine();

            taskManager.AddTask(title, dueDate, project);
            Console.WriteLine("Task added successfully!");
        }

        static void MarkTaskAsDone(TaskManager taskManager)
        {
            ViewTasks(taskManager);
            Console.Write("Enter task number to mark as done: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= taskManager.Tasks.Count)
            {
                taskManager.MarkTaskAsDone(index - 1);
                Console.WriteLine("Task marked as done!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void RemoveTask(TaskManager taskManager)
        {
            ViewTasks(taskManager);
            Console.Write("Enter task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= taskManager.Tasks.Count)
            {
                taskManager.RemoveTask(index - 1);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}
