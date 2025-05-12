using Microsoft.EntityFrameworkCore;
using C_Stocke.Entities;

namespace C_Stocke.Context
{
    public class GestionStockDbContext : DbContext
    {
        public GestionStockDbContext(DbContextOptions<GestionStockDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Details_Commande> Details_Commandes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Details_Commande>()
                .HasKey(dc => new { dc.ID_Commande, dc.ID_Produit });

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Client>()
               .Property(c => c.Nom_Client)
               .IsRequired()
               .HasMaxLength(100);
        }
        public void Seed()
        {
            if (!Clients.Any())
            {
                Clients.AddRange(
                    new Client
                    {
                        Nom_Client = "Dupont",
                        Prenom_Client = "Alice",
                        Adresse_Client = "123 Rue Principale",
                        Telephone_Client = "0600000000",
                        Pays_Client = "France",
                        Ville_Client = "Paris",
                        Email_Client = "alice@example.com"
                    }
                );
            }
            // ✅ Ajout des catégories si elles n'existent pas
            if (!Categories.Any())
            {
                Categories.AddRange(
                    new Categorie { Nom_Categorie = "Vêtements Bébé" },
                    new Categorie { Nom_Categorie = "Jouets" }
                );
                SaveChanges(); // Il faut enregistrer ici pour que les ID soient générés
            }

            // ✅ Récupération des catégories insérées
            var vetements = Categories.FirstOrDefault(c => c.Nom_Categorie == "Vêtements Bébé");
            var jouets = Categories.FirstOrDefault(c => c.Nom_Categorie == "Jouets");

           

            if (!Utilisateurs.Any())
            {
                Utilisateurs.Add(new Utilisateur
                {
                    NomUtilisateur = "admin",
                    Mot_De_Passe = "admin123"
                });

                Utilisateurs.Add(new Utilisateur
                {
                    NomUtilisateur = "membre",
                    Mot_De_Passe = "pass123"
                });

                SaveChanges();
            }


            if (!Produits.Any())
            {
                Produits.AddRange(
                    new Produit
                    {
                        Nom_Produit = "Body Bébé Coton",
                        Prix_Produit = 9.99m,
                        Quantite_Produit = 100,
                        ID_CATEGORIE = vetements.ID_CATEGORIE
                    },
                    new Produit
                    {
                        Nom_Produit = "Peluche Lapin",
                        Prix_Produit = 14.50m,
                        Quantite_Produit = 50,
                        ID_CATEGORIE = jouets.ID_CATEGORIE
                    }
                );
                SaveChanges();
            }
            

        }



    }
}