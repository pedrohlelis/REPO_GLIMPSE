using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WorkspaceGlimpse.Models;

namespace WorkspaceGlimpse.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        [HttpPost("CreateUser")]
        public bool PostUser([FromForm] User user)
        {
                using(var _context = new GlimpseContext()) 
                {
                    user.UserId = 0;
                    user.IsActive = true;
                    _context.Users.Add(user);
                    _context.SaveChanges();
                }
                return true;
        }

        [HttpGet("UsersList")]
        public List<User> GetAllUsers()
        {
            using (var _context = new GlimpseContext())
            {
                return _context.Users.ToList();
            }
        }
    }
}
