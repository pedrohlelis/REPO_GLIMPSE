using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkspaceGlimpse.Models
{
    // Classe que representa um cliente.
    public class User
    {
    
        private int _userId;
        private String _userName;
        private String _userEmail;
        private String _userPassword;
        private String _profileImage;
        [Key]
        public int userId {get; set;}
        public String userName {get; set;}
        public String userEmail {get; set;}
        public String userPassword {get; set;}
        public String profileImage {get; set;}
    }
}