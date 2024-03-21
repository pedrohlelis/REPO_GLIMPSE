using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkspaceGlimpse
{
    public class User
    {
        private int _UserId;
        private String _UserName;
        private String _UserEmail;
        private String _UserPassword;
        private String _ProfilePic;

        public int IdUsuario {get{return _UserId;} set{}}
        public String UserName {get{return _UserName;} set{}}
        public String UserEmail {get{return _UserEmail;} set{}}
        public String UserPassword {get{return _UserPassword;} set{}}
        public String ProfilePic {get{return _ProfilePic;} set{}}
    }
}