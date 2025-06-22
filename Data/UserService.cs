using Carpass_Profilling.Models;
using System.Threading;
using Microsoft.AspNetCore.Http;

namespace Carpass_Profilling.Data
{
    public class UserService
    {
        private readonly DataContext context;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly AsyncLocal<string> _currentUserName = new AsyncLocal<string>();

        public UserService(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.httpContextAccessor = httpContextAccessor;
        }

        public bool SaveUser(User user)
        {
            bool isExist = context.Users.Any(x => x.Email == user.Email);
            if (!isExist)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public User? Verify(string email, string password)
        {
            return context.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower()
                    && x.Password == password);
        }

        public User? GetUserByEmail(string email)
        {
            return context.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }

        public string GetCurrentUserName()
        {
            return _currentUserName.Value;
        }

        public void SetCurrentUserName(string name)
        {
            _currentUserName.Value = name;
        }

        // New method to get current user's email
        public string GetCurrentUserEmail()
        {
            return httpContextAccessor.HttpContext?.User?.Identity?.Name ?? string.Empty;
        }

        // New method to update user information
        public bool UpdateUser(User user)
        {
            var existingUser = context.Users.FirstOrDefault(x => x.Email == user.Email);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Gender = user.Gender;
                existingUser.Birthday = user.Birthday;
                if (!string.IsNullOrEmpty(user.Password))
                {
                    existingUser.Password = user.Password; // In a real app, you'd hash this password
                }
                existingUser.Image = user.Image;

                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}