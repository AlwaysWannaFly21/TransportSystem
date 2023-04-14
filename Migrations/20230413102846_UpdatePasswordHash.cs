using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePasswordHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "password_hash",
                table: "user",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "user");
        }
    }
}
