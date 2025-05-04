using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C_Stocke.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID_CATEGORIE = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom_Categorie = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID_CATEGORIE);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID_Client = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom_Client = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Prenom_Client = table.Column<string>(type: "TEXT", nullable: true),
                    Adresse_Client = table.Column<string>(type: "TEXT", nullable: true),
                    Telephone_Client = table.Column<string>(type: "TEXT", nullable: true),
                    Pays_Client = table.Column<string>(type: "TEXT", nullable: true),
                    Ville_Client = table.Column<string>(type: "TEXT", nullable: true),
                    Email_Client = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID_Client);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    NomUtilisateur = table.Column<string>(type: "TEXT", nullable: false),
                    Mot_De_Passe = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.NomUtilisateur);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    ID_Produit = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom_Produit = table.Column<string>(type: "TEXT", nullable: true),
                    Quantite_Produit = table.Column<int>(type: "INTEGER", nullable: false),
                    Prix_Produit = table.Column<decimal>(type: "TEXT", nullable: false),
                    Image_Produit = table.Column<string>(type: "TEXT", nullable: true),
                    ID_CATEGORIE = table.Column<int>(type: "INTEGER", nullable: false),
                    CategorieID_CATEGORIE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.ID_Produit);
                    table.ForeignKey(
                        name: "FK_Produits_Categories_CategorieID_CATEGORIE",
                        column: x => x.CategorieID_CATEGORIE,
                        principalTable: "Categories",
                        principalColumn: "ID_CATEGORIE");
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    ID_Commande = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DATE_Commande = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ID_Client = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientID_Client = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.ID_Commande);
                    table.ForeignKey(
                        name: "FK_Commandes_Clients_ClientID_Client",
                        column: x => x.ClientID_Client,
                        principalTable: "Clients",
                        principalColumn: "ID_Client");
                });

            migrationBuilder.CreateTable(
                name: "Details_Commandes",
                columns: table => new
                {
                    ID_Commande = table.Column<int>(type: "INTEGER", nullable: false),
                    ID_Produit = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantite = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details_Commandes", x => new { x.ID_Commande, x.ID_Produit });
                    table.ForeignKey(
                        name: "FK_Details_Commandes_Commandes_ID_Commande",
                        column: x => x.ID_Commande,
                        principalTable: "Commandes",
                        principalColumn: "ID_Commande",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Details_Commandes_Produits_ID_Produit",
                        column: x => x.ID_Produit,
                        principalTable: "Produits",
                        principalColumn: "ID_Produit",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ClientID_Client",
                table: "Commandes",
                column: "ClientID_Client");

            migrationBuilder.CreateIndex(
                name: "IX_Details_Commandes_ID_Produit",
                table: "Details_Commandes",
                column: "ID_Produit");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategorieID_CATEGORIE",
                table: "Produits",
                column: "CategorieID_CATEGORIE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details_Commandes");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
