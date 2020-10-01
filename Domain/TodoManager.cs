using System.Collections.Generic;

namespace TodoApp
{
    class TodoManager
    {
        List<Todo> todoItems = new List<Todo>();

        public void AddTodoItem(string title)
        {
            Todo newTodoItem = new Todo();
            newTodoItem.title = title;
            todoItems.Add(newTodoItem);
        }

        public void SetTodoItem(int index, bool isDone)
        {
            todoItems[index].isDone = isDone;
        }

        public void RemoveTodoItem(int index)
        {
            todoItems.RemoveAt(index);
        }
    }
}