using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace TodoApp
{
    class TodoManager
    {
        private readonly string connectionString;
        
        public TodoManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<TodoItem> GetTodoItems()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<TodoItem>("SELECT Id, Created, Deadline, Title FROM Todo");
            }
        }

        public void AddTodoItem(TodoItem todo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute("INSERT INTO Todo (Title, Deadline) values (@Title, @Deadline)", todo);
            }
        }

        public void RemoveTodoItem(int todoId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute("DELETE FROM Todo WHERE Id = @Id", new { Id = todoId });
            }
        }
        
        
    }
}