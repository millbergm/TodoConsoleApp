using System.Collections.Generic;

namespace TodoApp
{
    class TodoManager
    {
        List<TodoItem> listOfTodoItems = new List<TodoItem>();

        public void AddTodoItem(string title)
        {
            TodoItem newTodoItem = new TodoItem();
            newTodoItem.Title = title;
            listOfTodoItems.Add(newTodoItem);
        }

        public void SetTodoItem(int index, bool isDone)
        {
            listOfTodoItems[index].IsDone = isDone;
        }

        public void RemoveTodoItem(int index)
        {
            listOfTodoItems.RemoveAt(index);
        }
    }
}