using InterviewPanelManagement.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace InterviewPanelManagement.Data
{
    public class InterviewDbContext:DbContext
    {
        public InterviewDbContext(DbContextOptions options):base(options)
        {
          
        }
        public DbSet<Candidate> candidates { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Interview> interviews { get; set; }
        public DbSet<Panel> panels { get; set; }
        public DbSet<Rating> ratings { get; set; }  
        public DbSet<Role> roles { get; set; }
        public DbSet<Skill> skills { get; set; }
    }
}
