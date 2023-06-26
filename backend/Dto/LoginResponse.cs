using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dto
{
    public class LoginResponse
    {
        public string? Token { get; set; }
        public string? ErrorMessage { get; set; }
    }
}