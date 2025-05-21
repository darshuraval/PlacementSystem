using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlacementSystem.Migrations
{
    /// <inheritdoc />
    public partial class temp1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SelectionProcess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectionProcess", x => x.Id);
                });

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
                name: "IX_CampusDriveNotificationSelectionProcess_SelectionProcessesId",
                table: "CampusDriveNotificationSelectionProcess",
                column: "SelectionProcessesId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectionProcess_ProcessName",
                table: "SelectionProcess",
                column: "ProcessName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampusDriveNotificationSelectionProcess");

            migrationBuilder.DropTable(
                name: "SelectionProcess");
        }
    }
}
