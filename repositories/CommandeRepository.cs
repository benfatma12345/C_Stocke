using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Stocke.Context;
using C_Stocke.Entities;
using Microsoft.EntityFrameworkCore;

namespace C_Stocke.Repositories
{
    public class CommandeRepository : IDisposable
    {
        private readonly GestionStockDbContext _context;
        private bool _disposed = false;

        public CommandeRepository(GestionStockDbContext context)
        {
            _context = context;
        }

        // ------------------------
        // Méthodes synchrones
        // ------------------------

        public IEnumerable<Commande> GetAll()
        {
            return _context.Commandes
                           .Include(c => c.Client)
                           .Include(c => c.Details_Commandes)
                           .ThenInclude(d => d.Produit)
                           .ToList();
        }

        public Commande GetById(int id)
        {
            return _context.Commandes
                           .Include(c => c.Client)
                           .Include(c => c.Details_Commandes)
                           .ThenInclude(d => d.Produit)
                           .FirstOrDefault(c => c.ID_Commande == id);
        }

        public void Add(Commande commande)
        {
            commande.CalculerTotaux();
            _context.Commandes.Add(commande);
            _context.SaveChanges();
        }

        public void Update(Commande commande)
        {
            commande.CalculerTotaux();
            _context.Entry(commande).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var commande = _context.Commandes.Find(id);
            if (commande != null)
            {
                _context.Commandes.Remove(commande);
                _context.SaveChanges();
            }
        }

        // ------------------------
        // Méthodes asynchrones
        // ------------------------

        public async Task<IEnumerable<Commande>> GetAllAsync()
        {
            return await _context.Commandes
                                 .Include(c => c.Client)
                                 .Include(c => c.Details_Commandes)
                                 .ThenInclude(d => d.Produit)
                                 .ToListAsync();
        }

        public async Task<Commande?> GetByIdAsync(int id)
        {
            return await _context.Commandes
                                 .Include(c => c.Client)
                                 .Include(c => c.Details_Commandes)
                                 .ThenInclude(d => d.Produit)
                                 .FirstOrDefaultAsync(c => c.ID_Commande == id);
        }

        public async Task AddAsync(Commande commande)
        {
            commande.CalculerTotaux();
            await _context.Commandes.AddAsync(commande);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Commande commande)
        {
            commande.CalculerTotaux();
            _context.Entry(commande).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var commande = await _context.Commandes.FindAsync(id);
            if (commande != null)
            {
                _context.Commandes.Remove(commande);
                await _context.SaveChangesAsync();
            }
        }

        // ------------------------
        // Méthode utilitaire
        // ------------------------

        public decimal CalculerTotalCommande(int idCommande)
        {
            var commande = GetById(idCommande);
            commande?.CalculerTotaux();
            return commande?.TotalTTC ?? 0;
        }

        // ------------------------
        // Implémentation de IDisposable
        // ------------------------

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
