using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkspaceGlimpse
{
    // Classe que representa um cliente.
    public class Usuario
    {
        private int _IdUsuario;
        private String _NomeUsuario;
        private String _EmailUsuario;
        private String _SenhaUsuario;
        private String _ImagemPerfil;

        public int IdUsuario {get{return _IdUsuario;} set{}}
        public String NomeUsuario {get{return _NomeUsuario;} set{}}
        public String EmailUsuario {get{return _EmailUsuario;} set{}}
        public String SenhaUsuario {get{return _SenhaUsuario;} set{}}
        public String ImagemPerfil {get{return _ImagemPerfil;} set{}}
    }
}