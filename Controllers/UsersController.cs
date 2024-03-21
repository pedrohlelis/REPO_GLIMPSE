using Microsoft.AspNetCore.Mvc;

namespace WorkspaceGlimpse;

public class UsuariosController{
    [HttpGet("UsersList")]
    public List<User> GetAllUsers()
    {
        using (var _context = new GlimpseContext())
        {
            return _context.Users.ToList();
        }
    }
}
