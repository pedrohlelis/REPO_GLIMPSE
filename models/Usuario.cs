using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkspaceGlimpse
{
    // Classe que representa um cliente.
    public class Usuario
    {
        private int IdUsuario;
        private String NomeUsuario;
        private String EmailUsuario;
        private String SenhaUsuario;
        private String imagemPerfil;
    }
}