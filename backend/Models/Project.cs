using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }

        public List<Todo> Todos { get; set; } = new(); 
        public List<AppUserProject> AppUsers { get; set; } = new();
    }
}