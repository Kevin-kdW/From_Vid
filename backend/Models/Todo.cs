using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public TodoStatus Status { get; set; }

        public int ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}