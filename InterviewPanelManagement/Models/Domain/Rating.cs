using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewPanelManagement.Models.Domain
{
    public class Rating
    {
        public int Id { get; set; }
        [Required]
        public int HrRating { get; set; }
        public string HrComment { get; set;}
        [Required]
        public int TechRating { get; set;}
        public string TechComment { get; set;}
        [Required]
        [ForeignKey("Candidate")]

        public int CandidateId { get; set; } 
        public Candidate Candidate { get; set; }
    }
}
