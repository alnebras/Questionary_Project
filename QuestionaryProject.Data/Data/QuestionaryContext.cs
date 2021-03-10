using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.Data.Models;
using QuestionaryProject.Data.Models;

namespace QuestionaryProject.Data.Data
{
    public class QuestionaryContext : DbContext
    {
        public QuestionaryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        //public DbSet<QuestionaryInformation> QuestionaryInformations { get; set; }
        public DbSet<QuestionaryProject.Data.Models.UserAnswersSelection> UserAsnswers { get; set; }
        public DbSet<Models.UserAnswer> UserAnswersSelection { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAnswersSelection>().HasKey(a => (new { a.UserName, a.SubmissionDate, a.QuestionId }));
            modelBuilder.Entity<UserAnswer>().HasOne(a => a.Answer).WithMany(a => a.UserAnswers);
            modelBuilder.Entity<UserAnswer>().HasOne(a => a.UserAnswersSelection).WithMany(a => a.UserAnswers);
            modelBuilder.Entity<UserAnswer>().HasKey(a => (new { a.UserName, a.SubmissionDate, a.QuestionId, a.AnswerId }));
            //modelBuilder.Entity<Answer>().HasMany(a => a.UserAnswers).WithMany(a => a.Answers);
            modelBuilder.Seed();
        }
    }
}
