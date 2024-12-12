using System;
using System.IO;
using System.Text.Json;

namespace Individual_project
{
    internal static class FileHandler
    {
        private const string FileName = "ToDoList.json";

        public static void Save(TaskManager taskManager)
        {
            try
            {
                string json = JsonSerializer.Serialize(taskManager.Tasks, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FileName, json);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tasks saved successfully.");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error saving tasks: {ex.Message}");
                Console.ResetColor();
            }
        }

        public static void Load(TaskManager taskManager)
        {
            if (!File.Exists(FileName))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No saved tasks found. Starting with an empty list.");
                Console.ResetColor();
                return;
            }

            try
            {
                string json = File.ReadAllText(FileName);
                taskManager.Tasks = JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tasks loaded successfully.");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error loading tasks: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
