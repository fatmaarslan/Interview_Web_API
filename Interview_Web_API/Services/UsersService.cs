using Interview_Web_API.Models;
using Interview_Web_API.Database;
using Microsoft.EntityFrameworkCore;

namespace Interview_Web_API.Services
{

    public class UsersService
    {
        private readonly DataContext _context;

        public UsersService(DataContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<User> GetUsersByProjectId(int projectId)
        {
            return _context.Users.Where(u => u.ProjectID == projectId).ToList();
        }

        public void DeleteUsersByProjectId(int projectId)
        {
            var usersToDelete = _context.Users.Where(u => u.ProjectID == projectId).ToList();
            _context.Users.RemoveRange(usersToDelete);
            _context.SaveChanges();
        }
    }


}
