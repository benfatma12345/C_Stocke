using C_Stocke.Context;
using C_Stocke.Entities;
using Microsoft.EntityFrameworkCore; // Nécessaire pour Include
using System.Collections.Generic;
using System.Linq;

namespace C_Stocke.Repositories
{
    public class ProduitRepository : IDisposable
    {
        private readonly GestionStockDbContext _context;

        public ProduitRepository(GestionStockDbContext context)
        {
            _context = context;
        }

        // Méthode GetAll qui inclut la catégorie
       
        public IEnumerable<Produit> GetAll()
        {
            return _context.Produits.ToList();
        }
        public void Dispose()
        {

        }
        public Produit GetById(int id)
        {
            return _context.Produits
                .Include(p => p.Categorie) // Optionnel, si tu veux charger la catégorie en même temps
                .FirstOrDefault(p => p.ID_Produit == id);
        }

        public void Add(Produit produit)
        {
            _context.Produits.Add(produit);
            _context.SaveChanges();
        }

        public void Update(Produit produit)
        {
            _context.Produits.Update(produit);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var produit = _context.Produits.Find(id);
            if (produit != null)
            {
                _context.Produits.Remove(produit);
                _context.SaveChanges();
            }
        }
    }
}
