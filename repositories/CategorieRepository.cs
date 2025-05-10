
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using C_Stocke.Context;
using C_Stocke.Entities;
using Microsoft.EntityFrameworkCore;
namespace C_Stocke.Repositories
{
    public class CategorieRepository
    {
        private readonly GestionStockDbContext _context;

        public CategorieRepository(GestionStockDbContext context)
        {
            _context = context;
        }

        public List<Categorie> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Categorie GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        // Ajoutez cette méthode manquante
        public Categorie GetByName(string name)
        {
            return _context.Categories
                .FirstOrDefault(c => c.Nom_Categorie.ToLower() == name.ToLower());
        }

        public void Add(Categorie categorie)
        {
            _context.Categories.Add(categorie);
            _context.SaveChanges();
        }

        public void Update(Categorie categorie)
        {
            _context.Entry(categorie).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categorie = _context.Categories.Find(id);
            if (categorie != null)
            {
                _context.Categories.Remove(categorie);
                _context.SaveChanges();
            }
        }
      
    }
}