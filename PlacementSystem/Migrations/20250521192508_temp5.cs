using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlacementSystem.Migrations
{
    /// <inheritdoc />
    public partial class temp5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampusDriveNotification_Company_CompanyId",
                table: "CampusDriveNotification");

            migrationBuilder.DropTable(
                name: "CampusDriveNotificationSelectionProcess");

            migrationBuilder.DropIndex(
                name: "IX_SelectionProcess_ProcessName",
                table: "SelectionProcess");

            migrationBuilder.DropIndex(
                name: "IX_CampusDriveNotification_CompanyId",
                table: "CampusDriveNotification");

            migrationBuilder.AlterColumn<string>(
                name: "ProcessName",
                table: "SelectionProcess",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "SelectionProcessId",
                table: "CampusDriveNotification",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ProcessName",
                table: "SelectionProcess",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "CampusDriveNotificationSelectionProcess",
                columns: table => new
                {
                    CampusDriveNotificationsId = table.Column<int>(type: "int", nullable: false),
                    SelectionProcessesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampusDriveNotificationSelectionProcess", x => new { x.CampusDriveNotificationsId, x.SelectionProcessesId });
                    table.ForeignKey(
                        name: "FK_CampusDriveNotificationSelectionProcess_CampusDriveNotification_CampusDriveNotificationsId",
                        column: x => x.CampusDriveNotificationsId,
                        principalTable: "CampusDriveNotification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampusDriveNotificationSelectionProcess_SelectionProcess_SelectionProcessesId",
                        column: x => x.SelectionProcessesId,
                        principalTable: "SelectionProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SelectionProcess_ProcessName",
                table: "SelectionProcess",
                column: "ProcessName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CampusDriveNotification_CompanyId",
                table: "CampusDriveNotification",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CampusDriveNotificationSelectionProcess_SelectionProcessesId",
                table: "CampusDriveNotificationSelectionProcess",
                column: "SelectionProcessesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CampusDriveNotification_Company_CompanyId",
                table: "CampusDriveNotification",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
