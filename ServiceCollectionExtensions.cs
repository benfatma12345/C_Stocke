using Microsoft.Extensions.DependencyInjection;
using C_Stocke.Repositories;
using C_Stocke.Services;
using C_Stocke.Clients;
using System;
using C_Stocke.Auth;
using C_Stocke.Context;
using Microsoft.EntityFrameworkCore;

namespace C_Stocke
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {// Enregistrer tous les services nécessaires ici
            services.AddDbContext<GestionStockDbContext>(options =>
            options.UseSqlite("Data Source=gestion_stock.db"));

             services.AddTransient<UserControlClient>(); // Assurez-vous que UserControlClient est enregistré
            
        }
    }
}
