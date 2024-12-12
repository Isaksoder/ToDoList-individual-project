To-Do List Application
A console-based To-Do List application built in C#. This project demonstrates the use of object-oriented programming (OOP), file handling, and creating a user-friendly interface for managing tasks.

============================================================================================

Features

- Add Tasks: Create new tasks with a title, due date, and project name.
- View Tasks: Display all tasks, categorized as pending or completed, with color-coded statuses:
- Yellow for pending tasks.
- Green for completed tasks.
- Mark Tasks as Done: Update a task's status to completed.
- Remove Tasks: Delete tasks from the list.
- Persistent Storage: Save tasks to a file and reload them when the application restarts.

============================================================================================

Code Structure
The project is divided into four main components:

1. Task
Represents an individual task with the following attributes:
- Title: The name of the task.
- DueDate: The task's deadline.
- IsDone: A boolean indicating if the task is completed.
- Project: The project category the task belongs to.


2. TaskManager
Handles the list of tasks and provides methods to:

- Add new tasks.
- Remove tasks.
- Mark tasks as completed.
- Sort and retrieve tasks.


3. Program
The main entry point of the application. It:

- Provides a menu for user interaction.
- Handles user input and calls the appropriate methods in TaskManager.


4. FileHandler
Manages file operations, including:

- Saving tasks to a JSON file.
- Loading tasks from a JSON file upon application startup.

============================================================================================

Development Process

Tools Used
- Language: C#
- IDE: Visual Studio
- File Handling: JSON Serialization

Challenges
- One of the major challenges was implementing persistent storage to save and load tasks using JSON. Debugging issues with file handling required thorough testing and reviewing documentation.

============================================================================================

Lessons Learned
- Planning and breaking the project into smaller tasks made the development process smoother.
- Debugging frequently and using meaningful method names helped maintain clarity in the code.
- Testing the application after every feature ensured stability.
