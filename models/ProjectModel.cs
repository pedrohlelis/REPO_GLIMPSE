using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkspaceGlimpse.Models {
    public class Project {
        [Key]
        public int ProjectId { get; set; }
    }
}