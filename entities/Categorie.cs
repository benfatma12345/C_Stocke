using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Stocke.Entities
{
    public class Categorie
    {
        [Key]
        public int ID_CATEGORIE { get; set; }
        public string? Nom_Categorie { get; set; }

        public virtual ICollection<Produit>? Produits { get; set; }
    }

}
