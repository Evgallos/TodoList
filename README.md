### ✅ **Todo List - C# Certification Challenge**  
**In my courses for C# Certification via Microsoft Learning, I created this project: a simple and efficient TODO list application.**  
This console-based **To-do List** allows users to add tasks, delete tasks, and exit the application easily.  

---

## 📌 **Project Overview**  
This project was built using **C#** and provides a simple **text-based task manager**. Users can **add tasks**, **remove tasks**, and view their current task list.  

### 🎯 **Features**  
✔ **Add tasks** to the list ✍  
✔ **Delete tasks** by selecting their number ❌  
✔ **View all tasks** in a numbered list 📋  
✔ **Exit the application** when done 🚪  

---

## 🔧 **Technologies Used**  
- **C#** (Console Application)  
- **Lists & User Input Handling**  
- **Enum for menu choices**  

---

## 📂 **Repository**  
🔗 [GitHub Repository](https://www.github.com/Evgallos/TodoList)  

## 🌎 **Portfolio**  
📌 [Evgallos Portfolio - Live](https://www.evgallos.com)  

---

## ✨ **Key Code Snippet (YAML)**  
```yaml
tasks:
  - description: "Add a new task to the To-Do List"
    code: |
      Console.WriteLine("Enter Task: ");
      string task = Console.ReadLine();
      TOdoList.Add(task);
      Console.Clear();
      Console.WriteLine("Task added successfully");
  
  - description: "Delete a task from the To-Do List"
    code: |
      Console.WriteLine("Enter the number of the task you want to delete:");
      int taskNum;
      if (!int.TryParse(Console.ReadLine(), out taskNum) || taskNum <= 0 || taskNum > TOdoList.Count)
      {
          Console.WriteLine("Invalid task number.");
          return;
      }
      TOdoList.RemoveAt(taskNum - 1);
      Console.Clear();
      Console.WriteLine("Task deleted successfully!");
  
  - description: "Exit the application"
    code: |
      Console.WriteLine("Exiting the application...");
      Environment.Exit(0);
```
This YAML snippet represents different **To-Do List functionalities**, showing how tasks are **added, deleted, or exited** dynamically.

---

🚀 **Feel free to fork and enhance this project! Stay productive!** ✅
