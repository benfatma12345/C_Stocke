using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using C_Stocke.Context;
using C_Stocke.Repositories;
using C_Stocke.Produits;
using C_Stocke.Auth;
using C_Stocke.Clients;
using C_Stocke.Categories;
using C_Stock;

namespace C_Stocke
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            // Initialisation de la base de données
            using (var scope = ServiceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<GestionStockDbContext>();
                dbContext.Database.EnsureCreated();
            }

            // Lancer le formulaire de connexion
            using (var scope = ServiceProvider.CreateScope())
            {
                var loginForm = scope.ServiceProvider.GetRequiredService<Connextion>();

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var mainForm = scope.ServiceProvider.GetRequiredService<Menu>();
                    Application.Run(mainForm);
                }
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Configuration de la base de données
            services.AddDbContext<GestionStockDbContext>(options =>
                options.UseSqlite("Data Source=gestionstock.db"));

            // Enregistrement des repositories
            services.AddScoped< ClientRepository>();
            services.AddScoped<ProduitRepository>();
            services.AddScoped<CategorieRepository>();

            // Enregistrement des UserControls
            services.AddTransient<UserControlClient>();
            services.AddTransient<Liste_Produit>();
            services.AddTransient<UserCategori>();

            // Enregistrement des Forms  // Enregistrement des Forms
            services.AddTransient<Connextion>();
            services.AddSingleton<Menu>(); 
           
            services.AddTransient<Ajouter_Modifier_Client>();
            services.AddTransient<Ajoute_Modifier_Produit>();
            services.AddTransient<Ajouter_Modifier_Categorie>();
        }
    }
}