using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dto
{
    public class RegisterResponse
    {
        public int? UserId { get; set; }
        public string? ErrorMessage { get; set; }
    }
}