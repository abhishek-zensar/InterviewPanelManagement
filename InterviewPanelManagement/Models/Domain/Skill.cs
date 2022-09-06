using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewPanelManagement.Models.Domain
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        [Required]
        public string Skills { get; set; }
        [ForeignKey("Candidate")]
        [Required]
        public int CandidateId { get; set; }
        public Candidate Candidate  { get; set; }
    }
}
