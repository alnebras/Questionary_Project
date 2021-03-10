using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuestionaryProject.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswersSelection",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswersSelection", x => new { x.UserName, x.SubmissionDate, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_UserAnswersSelection_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAsnswers",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    UserAnswersSelectionUserName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserAnswersSelectionSubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserAnswersSelectionQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAsnswers", x => new { x.UserName, x.SubmissionDate, x.QuestionId, x.AnswerId });
                    table.ForeignKey(
                        name: "FK_UserAsnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "AnswerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAsnswers_UserAnswersSelection_UserAnswersSelectionUserName_UserAnswersSelectionSubmissionDate_UserAnswersSelectionQuesti~",
                        columns: x => new { x.UserAnswersSelectionUserName, x.UserAnswersSelectionSubmissionDate, x.UserAnswersSelectionQuestionId },
                        principalTable: "UserAnswersSelection",
                        principalColumns: new[] { "UserName", "SubmissionDate", "QuestionId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "QuestionName" },
                values: new object[] { 1, "What is an operating system?" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "QuestionName" },
                values: new object[] { 2, "To access the services of operating system, the interface is provided by the ___________" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "QuestionName" },
                values: new object[] { 3, "Which one of the following is not true?" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerName", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Collection of programs that manages hardware resources", 1 },
                    { 2, "System service provider to the application programs", 1 },
                    { 3, "Interface between the hardware and application programs", 1 },
                    { 4, "All of the mentioned", 1 },
                    { 5, "System calls", 2 },
                    { 6, "API", 2 },
                    { 7, "Library", 2 },
                    { 8, "Assembly instructions", 2 },
                    { 9, "kernel is the program that constitutes the central core of the operating system", 3 },
                    { 10, "kernel is the first part of operating system to load into memory during booting", 3 },
                    { 11, "kernel is made of various modules which can not be loaded in running operating system", 3 },
                    { 12, "kernel remains in the memory during the entire computer session", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswersSelection_QuestionId",
                table: "UserAnswersSelection",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAsnswers_AnswerId",
                table: "UserAsnswers",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAsnswers_UserAnswersSelectionUserName_UserAnswersSelectionSubmissionDate_UserAnswersSelectionQuestionId",
                table: "UserAsnswers",
                columns: new[] { "UserAnswersSelectionUserName", "UserAnswersSelectionSubmissionDate", "UserAnswersSelectionQuestionId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAsnswers");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "UserAnswersSelection");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
