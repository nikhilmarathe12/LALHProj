using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LALHData.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecID = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    EmpCode = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    FName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    LName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    AddrLine1 = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    AddrLine2 = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    AddrLine3 = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    AddrLine4 = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Telephone = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Mobile = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Fax = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    isEnable = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ReportingHead = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    ReportingHeadEmails = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    isForLAUser = table.Column<int>(type: "Int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterEmployee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserManager",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 4000, nullable: false),
                    EmpID = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    DefaultDiv = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    AAccess = table.Column<bool>(type: "bit", nullable: false),
                    isFullRights = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserManager", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WinAppMap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecID = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    WinUser = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    AppUser = table.Column<string>(type: "VARCHAR(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinAppMap", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterEmployee");

            migrationBuilder.DropTable(
                name: "UserManager");

            migrationBuilder.DropTable(
                name: "WinAppMap");
        }
    }
}
