using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class AppUserProject
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int ProjectId { get; set; }

        public AppUser? AppUser { get; set; }
        public Project? Project { get; set; }
    }
}