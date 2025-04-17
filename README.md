
*A simple console-based task manager built with C# and OOP principles.*  

---

## **🚀 How I Created the App**  
### **1. Project Setup**  
- Created a **C# Console App** in Visual Studio / .NET CLI.  
- Structured the project into folders:  
  - `Models/` – For data classes (`Task`, `Priority`)  
  - `Services/` – Business logic (`TaskManager`)  
  - `Utilities/` – Helper methods (`ConsoleHelper`)  

### **2. Core Features**  
✅ **Add, Remove, Update, List Tasks**  
✅ **Task Properties:**  
   - `ID` (Auto-increment)  
   - `Title` (String)  
   - `DueDate` (DateTime)  
   - `Priority` (Enum: Low, Medium, High)  
✅ **Algorithms:**  
   - **Bubble Sort** (Sort tasks by priority)  
   - **Binary Search** (Find tasks by title)  

### **3. User Interaction**  
📌 **Console Menu:**  
```
1. Add Task  
2. Remove Task  
3. Update Task  
4. List All Tasks  
5. Sort Tasks by Priority  
6. Search Task by Title  
7. Exit  
```

---

## **🔍 OOP Principles Applied**  

### **1. Encapsulation (Data Hiding)**  
✔ **Private Fields** – `_tasks` list and `_nextId` are hidden inside `TaskManager`.  
✔ **Public Methods** – Only expose necessary operations (`AddTask`, `RemoveTask`).  

❌ **Struggle:** Initially made `_tasks` public—fixed by restricting access.  

### **2. Abstraction (Simplification)**  
✔ **TaskManager Class** – Hides sorting/searching logic behind simple methods (`SortTasksByPriority`, `BinarySearchByTitle`).  
✔ **ConsoleHelper** – Simplifies input/output handling.  

### **3. Inheritance (Not Used Yet)**  
❌ **Current:** No inheritance (could extend later, e.g., `UrgentTask : Task`).  

### **4. Polymorphism (Flexible Behavior)**  
✔ **Enum for Priority** – Different priorities (`Low`, `Medium`, `High`) behave uniformly.  
✔ **Method Overloading (Potential)** – Could add `AddTask` variants later.  

---

## **💡 Struggles & Lessons**  
1. **Naming Conflict:**  
   - **Error:** `Task` vs. `System.Threading.Tasks.Task`.  
   - **Fix:** Renamed to `TaskItem` (better long-term).  

2. **Bubble Sort Optimization:**  
   - Initially missed the `swapped` flag for early exit.  

3. **Binary Search Edge Cases:**  
   - Forgot to handle case-insensitive search at first.  

---

## **🔧 Future Refactors**  
1. **Error Handling**  
   - Add try-catch for file I/O (if storing tasks in a file later).  

2. **Dependency Injection**  
   - Decouple `TaskManager` from `ConsoleHelper` for testing.  

3. **Async/Await**  
   - Use `async` methods if switching to a database.  

4. **Unit Tests**  
   - Add tests for sorting/searching logic.  

5. **More OOP**  
   - Introduce interfaces (`ITaskManager`).  
   - Use inheritance for different task types.  

---

