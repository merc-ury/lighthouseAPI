using Microsoft.EntityFrameworkCore.Migrations;

namespace LighthouseAPI.Migrations
{
    public partial class RevisedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_UserID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UserID",
                table: "Notes");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Notes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Notes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserID",
                table: "Notes",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_UserID",
                table: "Notes",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
