using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.Data.Models;
using QuestionaryProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryProject.Data
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Question>().HasData(
                // Q1
                new Question { QuestionId = 1, QuestionName = "What is an operating system?" },
                // Q2
                new Question { QuestionId = 2, QuestionName = "To access the services of operating system, the interface is provided by the ___________" },
                // Q3
                new Question { QuestionId = 3, QuestionName = "Which one of the following is not true?" }
                );
            modelBuilder.Entity<Answer>().HasData(
                // Q1
                new Answer { AnswerId = 1, AnswerName = "Collection of programs that manages hardware resources", QuestionId = 1 },
                new Answer { AnswerId = 2, AnswerName = "System service provider to the application programs", QuestionId = 1 },
                new Answer { AnswerId = 3, AnswerName = "Interface between the hardware and application programs", QuestionId = 1 },
                new Answer { AnswerId = 4, AnswerName = "All of the mentioned", QuestionId = 1 },
                // Q2
                new Answer { AnswerId = 5, AnswerName = "System calls", QuestionId = 2 },
                new Answer { AnswerId = 6, AnswerName = "API", QuestionId = 2 },
                new Answer { AnswerId = 7, AnswerName = "Library", QuestionId = 2 },
                new Answer { AnswerId = 8, AnswerName = "Assembly instructions", QuestionId = 2 },
                // Q3
                new Answer { AnswerId = 9, AnswerName = "kernel is the program that constitutes the central core of the operating system", QuestionId = 3 },
                new Answer { AnswerId = 10, AnswerName = "kernel is the first part of operating system to load into memory during booting", QuestionId = 3 },
                new Answer { AnswerId = 11, AnswerName = "kernel is made of various modules which can not be loaded in running operating system", QuestionId = 3 },
                new Answer { AnswerId = 12, AnswerName = "kernel remains in the memory during the entire computer session", QuestionId = 3 }
                );

        }
    }
}
