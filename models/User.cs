using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WorkspaceGlimpse.Models
{
    public class User
    {
        private int _UserId;
        private String? _UserName;
        private String? _UserEmail;
        private String? _UserPassword;
        private String? _ProfilePic;
        private bool _IsActive;

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId {get{return _UserId;} set{_UserId = value;}}
        [Required]
        [MaxLength(100)]
        public String? UserName {get{return _UserName;} private set{_UserName = value;}}
        [Required]
        [MaxLength(100)]
        public String? UserEmail {get{return _UserEmail;} set{_UserEmail = value;}}
        [Required]
        [MaxLength(100)]
        public String? UserPassword {get{return _UserPassword;} set{_UserPassword = value;}}
        [Required]
        [MaxLength(150)]
        public String? ProfilePic {get{return _ProfilePic;} set{_ProfilePic = value;}}
        public bool IsActive {get{return _IsActive;} set{_IsActive = value;}}
    }
}