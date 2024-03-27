using Microsoft.AspNetCore.Mvc;
using WorkspaceGlimpse.Models;

namespace WorkspaceGlimpse.Controllers;

public class UserController{
    [HttpGet("List")]
    public List<User> GetAllUsers()
    {
        using (var _context = new GlimpseContext())
        {
            return _context.Users.ToList();
        }
    }
}
