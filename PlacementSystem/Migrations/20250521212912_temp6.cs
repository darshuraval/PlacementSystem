using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlacementSystem.Migrations
{
    /// <inheritdoc />
    public partial class temp6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampusDriveNotification_SelectionProcess_SelectionProcessId",
                table: "CampusDriveNotification");

            migrationBuilder.DropIndex(
                name: "IX_CampusDriveNotification_SelectionProcessId",
                table: "CampusDriveNotification");

            migrationBuilder.DropColumn(
                name: "SelectionProcessId",
                table: "CampusDriveNotification");

            migrationBuilder.DropColumn(
                name: "Batch",
                table: "Branch");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "SelectionProcess",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "SelectionProcess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "Company",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CampusDriveNotification",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "CampusDriveNotification",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "CampusDriveNotification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "Branch",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileId = table.Column<int>(type: "int", nullable: true),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "SelectionProcess");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "SelectionProcess");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "CampusDriveNotification");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "CampusDriveNotification");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "Branch");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CampusDriveNotification",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SelectionProcessId",
                table: "CampusDriveNotification",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Batch",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CampusDriveNotification_SelectionProcessId",
                table: "CampusDriveNotification",
                column: "SelectionProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_CampusDriveNotification_SelectionProcess_SelectionProcessId",
                table: "CampusDriveNotification",
                column: "SelectionProcessId",
                principalTable: "SelectionProcess",
                principalColumn: "Id");
        }
    }
}
