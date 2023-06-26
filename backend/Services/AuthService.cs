using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dto;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    public class AuthService
    {
        private readonly DataContext _db;
        public AuthService(DataContext db)
        {
            _db = db;
        }

        private string GetTokenForUser(AppUser appUser)
        {
            return $"{appUser.Username}{appUser.Password}";
        }

        //checks to see if user is in db with username and password. Returns token if user exists

        //Async needs Tasks and await keywords otherwise errors will occur
        public LoginResponse HandleLogin(LoginRequest request)
        {
            var response = new LoginResponse();
            var appUser = _db.AppUsers.Where(x => x.Username == request.Username).FirstOrDefault();
            if (appUser == null || appUser.Password != request.Password)
            {
                response.ErrorMessage = "Username or password ain't right. Try again!";
                return response;
            }

            response.Token = GetTokenForUser(appUser);

            return response;

            //return new LoginResponse { ErrorMessage = "That user doesn't exist :(" };
        }
        public RegisterResponse HandleRegister(RegisterRequest request)
        {
            var response = new RegisterResponse();
            var existingUser = _db.AppUsers.Where(x => x.Username == request.Username).FirstOrDefault();

            if (existingUser != null)
            {
                response.ErrorMessage = "Username exists already :(. Gotta enter another one";
                return response;
            }

            var newUser = new AppUser
            {
                Username = request.Username,
                Password = request.Password,
                GroupId = 2, // user group
            };

            _db.AppUsers.AddRange(newUser);
            _db.SaveChanges();

            response.UserId = newUser.Id;

            return response;
        }
    }
}