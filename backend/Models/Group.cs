using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<AppUser> AppUsers { get; set; } = new();

    }
}