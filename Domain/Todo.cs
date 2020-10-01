using System;
using System.Collections.Generic;

namespace TodoApp
{
    class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime Deadline { get; set; } //Not yet used for anything
    }
}