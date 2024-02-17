using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassroomBooking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddClassroom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassroomNumber",
                table: "Keys");

            migrationBuilder.DropColumn(
                name: "ClassroomNumber",
                table: "KeyRequests");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassroomId",
                table: "Keys",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClassroomId",
                table: "KeyRequests",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Building = table.Column<int>(type: "integer", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Keys_ClassroomId",
                table: "Keys",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyRequests_ClassroomId",
                table: "KeyRequests",
                column: "ClassroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_KeyRequests_Classrooms_ClassroomId",
                table: "KeyRequests",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Keys_Classrooms_ClassroomId",
                table: "Keys",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeyRequests_Classrooms_ClassroomId",
                table: "KeyRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Keys_Classrooms_ClassroomId",
                table: "Keys");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropIndex(
                name: "IX_Keys_ClassroomId",
                table: "Keys");

            migrationBuilder.DropIndex(
                name: "IX_KeyRequests_ClassroomId",
                table: "KeyRequests");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "Keys");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "KeyRequests");

            migrationBuilder.AddColumn<int>(
                name: "ClassroomNumber",
                table: "Keys",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassroomNumber",
                table: "KeyRequests",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
