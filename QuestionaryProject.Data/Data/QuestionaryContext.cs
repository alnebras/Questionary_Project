using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.Data.Models;

namespace QuestionaryProject.Data.Data
{
    public class QuestionaryContext : DbContext
    {
        public QuestionaryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<QuestionaryInformation> QuestionaryInformations { get; set; }
        public DbSet<UserAsnswers> UserAsnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
