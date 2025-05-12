using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C_Stocke.Migrations
{
    /// <inheritdoc />
    public partial class Creation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrixUnitaire",
                table: "Details_Commandes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RemisePourcentage",
                table: "Details_Commandes",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TauxTVA",
                table: "Commandes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalHT",
                table: "Commandes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalTTC",
                table: "Commandes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalTVA",
                table: "Commandes",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrixUnitaire",
                table: "Details_Commandes");

            migrationBuilder.DropColumn(
                name: "RemisePourcentage",
                table: "Details_Commandes");

            migrationBuilder.DropColumn(
                name: "TauxTVA",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "TotalHT",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "TotalTTC",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "TotalTVA",
                table: "Commandes");
        }
    }
}
