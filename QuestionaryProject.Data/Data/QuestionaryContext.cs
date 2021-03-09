using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryProject.Data.Data
{
    public class QuestionaryContext: DbContext
    {
        public QuestionaryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfigurationsFromAssembly(typeof(QuestionaryContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
