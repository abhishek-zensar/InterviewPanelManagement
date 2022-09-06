using System.ComponentModel.DataAnnotations;

namespace InterviewPanelManagement.Models.Domain
{
    public class Candidate
    {
        [Key]
        public int CandidateId { get; set; }
       
        [Required]
        public string FirstName { get; set;}
        [Required]
        public string LastName { get; set; }
        [Required]
       
        public string username { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,MaxLength(10)]
        public int Phone { get; set; }
        
        [Required]
        public int Experience { get; set; }
        [Required]
        public string Qualification { get; set; }
        [Required]
        public int NoticePeriod { get; set; }
        [Required]
        public string location { get; set; }
        


    }
}
