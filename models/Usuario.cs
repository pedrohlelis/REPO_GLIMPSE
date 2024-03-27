using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkspaceGlimpse.Models
{
    // Classe que representa um cliente.
    public class Usuario
    {
    
        private int _IdUsuario;
        private String _NomeUsuario;
        private String _EmailUsuario;
        private String _SenhaUsuario;
        private String _ImagemPerfil;
        [Key]
        public int IdUsuario {get; set;}
        public String NomeUsuario {get; set;}
        public String EmailUsuario {get; set;}
        public String SenhaUsuario {get; set;}
        public String ImagemPerfil {get; set;}
    }
}