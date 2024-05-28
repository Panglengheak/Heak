using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.Migrations
{
    /// <inheritdoc />
    public partial class LMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Librarians",
                columns: table => new
                {
                    LibrarianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibrarianCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LibrarianName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<string>(type: "datetime2", nullable: false),
                    Phone = table.Column<DateTime>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<decimal>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarians", x => x.LibrarianId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Librarians");
        }
    }
}
