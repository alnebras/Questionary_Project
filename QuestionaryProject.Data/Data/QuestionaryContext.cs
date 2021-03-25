using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.Data.Models;
using QuestionaryProject.Data.Models;

namespace QuestionaryProject.Data
{
    public class QuestionaryContext : DbContext
    {
        public QuestionaryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }        
        public DbSet<UserAnswer> UserAsnswers  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          
            modelBuilder.Seed();
        }
    }
}
