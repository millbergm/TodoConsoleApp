
namespace TodoApp
{
    class TodoItem
    {
        public int Id { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Deadline { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
    }
}