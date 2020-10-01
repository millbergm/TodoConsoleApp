using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main()
        {
            TodoManager todoManager = new TodoManager();

            todoManager.AddTodoItem("Rasta hunden");
            todoManager.AddTodoItem("Rasta den andra hunden");
            todoManager.AddTodoItem("Rasta papegojan");

            todoManager.SetTodoItem(0, true);
            todoManager.RemoveTodoItem(1);
        }
    }
}