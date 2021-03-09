using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuestionaryProject.Data.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionaryInformations",
                columns: table => new
                {
                    QuestionaryInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionaryInformations", x => x.QuestionaryInformationId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "UserAsnswers",
                columns: table => new
                {
                    UserAsnswersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionaryInformationId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAsnswers", x => x.UserAsnswersId);
                    table.ForeignKey(
                        name: "FK_UserAsnswers_QuestionaryInformations_QuestionaryInformationId",
                        column: x => x.QuestionaryInformationId,
                        principalTable: "QuestionaryInformations",
                        principalColumn: "QuestionaryInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAsnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAsnswersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_UserAsnswers_UserAsnswersId",
                        column: x => x.UserAsnswersId,
                        principalTable: "UserAsnswers",
                        principalColumn: "UserAsnswersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerName", "UserAsnswersId" },
                values: new object[,]
                {
                    { 1, "collection of programs that manages hardware resources", null },
                    { 2, "system service provider to the application programs", null },
                    { 3, "interface between the hardware and application programs", null },
                    { 4, "all of the mentioned", null },
                    { 5, "System calls", null },
                    { 6, "API", null },
                    { 7, "Library", null },
                    { 8, "Assembly instructions", null },
                    { 9, "kernel is the program that constitutes the central core of the operating system", null },
                    { 10, "kernel is the first part of operating system to load into memory during booting", null },
                    { 11, "kernel is made of various modules which can not be loaded in running operating system", null },
                    { 12, "kernel remains in the memory during the entire computer session", null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "QuestionName" },
                values: new object[,]
                {
                    { 1, "What is an operating system?" },
                    { 2, "To access the services of operating system, the interface is provided by the ___________" },
                    { 3, "Which one of the following is not true?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserAsnswersId",
                table: "Answers",
                column: "UserAsnswersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAsnswers_QuestionaryInformationId",
                table: "UserAsnswers",
                column: "QuestionaryInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAsnswers_QuestionId",
                table: "UserAsnswers",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "UserAsnswers");

            migrationBuilder.DropTable(
                name: "QuestionaryInformations");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
