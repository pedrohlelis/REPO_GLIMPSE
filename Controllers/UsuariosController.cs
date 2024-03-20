using Microsoft.AspNetCore.Mvc;

namespace WorkspaceGlimpse;

public class UsuariosController{
    [HttpGet("Listar")]
    public List<Usuario> GetTodosUsuarios()
    {
        using (var _context = new GlimpseContext())
        {
            return _context.Usuarios.ToList();
        }
    }
}
