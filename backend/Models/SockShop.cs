using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class SockShop
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<Sock> Socks { get; set; } = new();
    }
}