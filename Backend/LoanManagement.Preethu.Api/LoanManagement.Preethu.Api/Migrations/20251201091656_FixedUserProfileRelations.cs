using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanManagement.Preethu.Api.Migrations
{
    /// <inheritdoc />
    public partial class FixedUserProfileRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblFeedBackReplies_TblFeedBackQuestions_FeedBackQuestionFeedBackId",
                table: "TblFeedBackReplies");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "TblOfficers");

            migrationBuilder.RenameColumn(
                name: "FeedBackQuestionFeedBackId",
                table: "TblFeedBackReplies",
                newName: "FeedBackQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_TblFeedBackReplies_FeedBackQuestionFeedBackId",
                table: "TblFeedBackReplies",
                newName: "IX_TblFeedBackReplies_FeedBackQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblFeedBackReplies_TblFeedBackQuestions_FeedBackQuestionId",
                table: "TblFeedBackReplies",
                column: "FeedBackQuestionId",
                principalTable: "TblFeedBackQuestions",
                principalColumn: "FeedBackId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblFeedBackReplies_TblFeedBackQuestions_FeedBackQuestionId",
                table: "TblFeedBackReplies");

            migrationBuilder.RenameColumn(
                name: "FeedBackQuestionId",
                table: "TblFeedBackReplies",
                newName: "FeedBackQuestionFeedBackId");

            migrationBuilder.RenameIndex(
                name: "IX_TblFeedBackReplies_FeedBackQuestionId",
                table: "TblFeedBackReplies",
                newName: "IX_TblFeedBackReplies_FeedBackQuestionFeedBackId");

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "TblOfficers",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFeedBackReplies_TblFeedBackQuestions_FeedBackQuestionFeedBackId",
                table: "TblFeedBackReplies",
                column: "FeedBackQuestionFeedBackId",
                principalTable: "TblFeedBackQuestions",
                principalColumn: "FeedBackId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
