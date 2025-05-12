using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;          // <-- pour [Key]
using System.ComponentModel.DataAnnotations.Schema;

namespace C_Stocke.Entities
{
    public class Commande
    {
        [Key]
        public int ID_Commande { get; set; }
        public DateTime DATE_Commande { get; set; }
        public decimal TotalHT { get; set; }
        public decimal TauxTVA { get; set; }
        public decimal TotalTVA { get; set; }
        public decimal TotalTTC { get; set; }
        public int ID_Client { get; set; }
        public virtual Client? Client { get; set; }

        public virtual ICollection<Details_Commande>? Details_Commandes { get; set; }

        public void CalculerTotaux()
        {
            if (Details_Commandes != null && Details_Commandes.Any())
            {
                TotalHT = Details_Commandes.Sum(d => d.Quantite * d.PrixUnitaire);
                TotalTVA = TotalHT * (TauxTVA / 100);
                TotalTTC = TotalHT + TotalTVA;
            }
            else
            {
                TotalHT = 0;
                TotalTVA = 0;
                TotalTTC = 0;
            }
        }

    }
}