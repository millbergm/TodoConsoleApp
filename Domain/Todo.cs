using System;
using System.Collections.Generic;

namespace TodoApp
{
    class TodoItem
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public DateTime Deadline { get; set; } //Not yet used for anything
    }
}