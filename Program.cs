using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static List<Todo> todoItems = new List<Todo>();

        static void Main()
        {

            AddTodoItem("Rasta hunden");
            AddTodoItem("Rasta den andra hunden");
            AddTodoItem("Rasta papegojan");

            SetTodoItem(todoItems[0], true);

            RemoveTodoItem(todoItems[1]);
        }

        static void AddTodoItem(string title)
        {
            Todo newTodoItem = new Todo();
            newTodoItem.title = title;
            todoItems.Add(newTodoItem);
        }

        static void SetTodoItem(Todo todo, bool isDone)
        {
            todo.isDone = isDone;
        }

        static void RemoveTodoItem(Todo todo)
        {
            todoItems.Remove(todo);
        }
    }
}