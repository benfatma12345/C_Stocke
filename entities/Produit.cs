using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;          // <-- pour [Key]
using System.ComponentModel.DataAnnotations.Schema;

namespace C_Stocke.Entities
{
    public class Produit
    {
        [Key]
        public int ID_Produit { get; set; }
        public string? Nom_Produit { get; set; }
        public int Quantite_Produit { get; set; }
        public decimal Prix_Produit { get; set; }
        public string? Image_Produit { get; set; }

        public int ID_CATEGORIE { get; set; }
        public virtual Categorie? Categorie { get; set; }

        public virtual ICollection<Details_Commande>? Details_Commandes { get; set; }
    }

}
