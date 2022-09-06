using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewPanelManagement.Models.Domain
{
    public class Panel
    {
        [Key]
        public int PanelId { get; set; }
        [Required]
        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public Employee Employee { get; set; }
    }
}
