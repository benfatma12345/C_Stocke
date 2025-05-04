using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;          // <-- pour [Key]
using System.ComponentModel.DataAnnotations.Schema;

namespace C_Stocke.Entities
{
    public class Details_Commande
    {
        [Key, Column(Order = 0)]
        public int ID_Commande { get; set; }

        [Key, Column(Order = 1)]
        public int ID_Produit { get; set; }

        public int Quantite { get; set; }

        public virtual Commande? Commande { get; set; }
        public virtual Produit? Produit { get; set; }
    }

}
