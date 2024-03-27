using Microsoft.AspNetCore.Mvc;

namespace WorkspaceGlimpse;

public class UserController{
    [HttpGet("UsersList")]
    public List<User> GetAllUsers()
    {
        using (var _context = new GlimpseContext())
        {
            return _context.Users.ToList();
        }
    }
}
