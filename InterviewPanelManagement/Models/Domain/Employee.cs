using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewPanelManagement.Models.Domain
{
    public class Employee
    {   [Key]
        public int EmpId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }    
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }


    }
}
