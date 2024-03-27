using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkspaceGlimpse.Models {
    public class Project {
        [Key]
        public int projectId { get; set; }
        public string projectName { get; set; }
        public DateOnly creationDate { get; set; }
        public string projectDescription { get; set; }
    }
}