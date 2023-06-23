using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    [Index("Username", IsUnique = true)]
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;

        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public List<AppUserProject> Projects { get; set; } = new();
    }
}