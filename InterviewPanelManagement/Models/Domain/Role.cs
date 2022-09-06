using System.ComponentModel.DataAnnotations;

namespace InterviewPanelManagement.Models.Domain
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; } 
        [Required]
        public string RoleName { get; set; }
       
    }
}
