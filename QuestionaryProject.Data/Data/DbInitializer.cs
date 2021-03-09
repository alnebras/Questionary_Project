using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryProject.Data.Data
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Questions>().HasData(
                // Q1
                new Questions { QuestionId = 1, QuestionName = "What is an operating system?" },
                // Q2
                new Questions { QuestionId = 2, QuestionName = "To access the services of operating system, the interface is provided by the ___________" },
                // Q3
                new Questions { QuestionId = 3, QuestionName = "Which one of the following is not true?" }
                );
            modelBuilder.Entity<Answers>().HasData(
                // Q1
                new Answers { AnswerId = 1, AnswerName = "collection of programs that manages hardware resources" },
                new Answers { AnswerId = 2, AnswerName = "system service provider to the application programs" },
                new Answers { AnswerId = 3, AnswerName = "interface between the hardware and application programs" },
                new Answers { AnswerId = 4, AnswerName = "all of the mentioned" },
                // Q2
                new Answers { AnswerId = 5, AnswerName = "System calls" },
                new Answers { AnswerId = 6, AnswerName = "API" },
                new Answers { AnswerId = 7, AnswerName = "Library" },
                new Answers { AnswerId = 8, AnswerName = "Assembly instructions" },
                // Q3
                new Answers { AnswerId = 9, AnswerName = "kernel is the program that constitutes the central core of the operating system" },
                new Answers { AnswerId = 10, AnswerName = "kernel is the first part of operating system to load into memory during booting" },
                new Answers { AnswerId = 11, AnswerName = "kernel is made of various modules which can not be loaded in running operating system" },
                new Answers { AnswerId = 12, AnswerName = "kernel remains in the memory during the entire computer session" }
                );

        }
    }
}
