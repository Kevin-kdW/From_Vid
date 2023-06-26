using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dto;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    public class AuthController : BaseController
    {

        private readonly AuthService _auth;
        public AuthController(AuthService auth)
        {
            _auth = auth;
        }

        [HttpPost]
        public ActionResult<LoginResponse> Login(LoginRequest request)
        {
            var response =  _auth.HandleLogin(request);
            return new JsonResult(response);
        }
        [HttpPost]
        public ActionResult<RegisterResponse> Register(RegisterRequest request)
        {
            var response =  _auth.HandleRegister(request);
            return new JsonResult(response);
        }
    }
}