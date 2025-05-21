using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlacementSystem.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyHRName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyHRContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyHREmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampusDriveNotification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectionProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CTC = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Stipend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TraineeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBond = table.Column<bool>(type: "bit", nullable: true),
                    BondDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfJoining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EligibleCourses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDeadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeptCoordinatorNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptCoordinatorEmails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TPOCoordinatorNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TPOCoordinatorEmails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampusDriveNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampusDriveNotification_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampusDriveNotification_CompanyId",
                table: "CampusDriveNotification",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampusDriveNotification");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
