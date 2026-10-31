using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G_NET68_EF_Assignment_2.Migrations
{
    /// <inheritdoc />
    public partial class CapitalizeEinemail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Attendees",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Attendees",
                newName: "email");
        }
    }
}
