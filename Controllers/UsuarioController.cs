using Microsoft.AspNetCore.Mvc;
using WorkspaceGlimpse.Models;

namespace WorkspaceGlimpse.Controllers;

public class UsuarioController{
    [HttpGet("Listar")]
    public List<Usuario> GetTodosUsuarios()
    {
        using (var _context = new GlimpseContext())
        {
            return _context.Usuarios.ToList();
        }
    }
}
