using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace phadec.Migrations
{
    /// <inheritdoc />
    public partial class Intial_Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActiveSubstance",
                table: "Drug",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AtcCode",
                table: "Drug",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveSubstance",
                table: "Drug");

            migrationBuilder.DropColumn(
                name: "AtcCode",
                table: "Drug");
        }
    }
}
