﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuestionaryProject.Data.Data;

namespace QuestionaryProject.Data.Migrations
{
    [DbContext(typeof(QuestionaryContext))]
    partial class QuestionaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuestionaryProject.Data.Data.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            QuestionName = "What is an operating system?"
                        },
                        new
                        {
                            QuestionId = 2,
                            QuestionName = "To access the services of operating system, the interface is provided by the ___________"
                        },
                        new
                        {
                            QuestionId = 3,
                            QuestionName = "Which one of the following is not true?"
                        });
                });

            modelBuilder.Entity("QuestionaryProject.Data.Data.Models.UserAnswer", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int?>("UserAnswersSelectionQuestionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UserAnswersSelectionSubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAnswersSelectionUserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserName", "SubmissionDate", "QuestionId", "AnswerId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("UserAnswersSelectionUserName", "UserAnswersSelectionSubmissionDate", "UserAnswersSelectionQuestionId");

                    b.ToTable("UserAsnswers");
                });

            modelBuilder.Entity("QuestionaryProject.Data.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            AnswerName = "Collection of programs that manages hardware resources",
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 2,
                            AnswerName = "System service provider to the application programs",
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 3,
                            AnswerName = "Interface between the hardware and application programs",
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 4,
                            AnswerName = "All of the mentioned",
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 5,
                            AnswerName = "System calls",
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 6,
                            AnswerName = "API",
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 7,
                            AnswerName = "Library",
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 8,
                            AnswerName = "Assembly instructions",
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 9,
                            AnswerName = "kernel is the program that constitutes the central core of the operating system",
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 10,
                            AnswerName = "kernel is the first part of operating system to load into memory during booting",
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 11,
                            AnswerName = "kernel is made of various modules which can not be loaded in running operating system",
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 12,
                            AnswerName = "kernel remains in the memory during the entire computer session",
                            QuestionId = 3
                        });
                });

            modelBuilder.Entity("QuestionaryProject.Data.Models.UserAnswersSelection", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("UserName", "SubmissionDate", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("UserAnswersSelection");
                });

            modelBuilder.Entity("QuestionaryProject.Data.Data.Models.UserAnswer", b =>
                {
                    b.HasOne("QuestionaryProject.Data.Models.Answer", "Answer")
                        .WithMany("UserAnswers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestionaryProject.Data.Models.UserAnswersSelection", "UserAnswersSelection")
                        .WithMany("UserAnswers")
                        .HasForeignKey("UserAnswersSelectionUserName", "UserAnswersSelectionSubmissionDate", "UserAnswersSelectionQuestionId");

                    b.Navigation("Answer");

                    b.Navigation("UserAnswersSelection");
                });

            modelBuilder.Entity("QuestionaryProject.Data.Models.Answer", b =>
                {
                    b.HasOne("QuestionaryProject.Data.Data.Models.Question", "Questions")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("QuestionaryProject.Data.Models.UserAnswersSelection", b =>
                {
                    b.HasOne("QuestionaryProject.Data.Data.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuestionaryProject.Data.Data.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("QuestionaryProject.Data.Models.Answer", b =>
                {
                    b.Navigation("UserAnswers");
                });

            modelBuilder.Entity("QuestionaryProject.Data.Models.UserAnswersSelection", b =>
                {
                    b.Navigation("UserAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
