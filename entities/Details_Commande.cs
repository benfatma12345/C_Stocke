using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_Stocke.Entities
{
    public class Details_Commande
    {
        [Key, Column(Order = 0)]
        public int ID_Commande { get; set; }

        [Key, Column(Order = 1)]
        public int ID_Produit { get; set; }

        [Required]
        public int Quantite { get; set; }

        public decimal PrixUnitaire { get; set; }


          public decimal RemisePourcentage { get; set; } = 0;

        [NotMapped] // Ne sera pas stocké en base
        public decimal MontantRemise => PrixUnitaire * Quantite * (RemisePourcentage / 100);

        [NotMapped]
        public decimal TotalLigne => (PrixUnitaire * Quantite) - MontantRemise;

        // Relations
        [ForeignKey("ID_Commande")]
        public virtual Commande? Commande { get; set; }

        [ForeignKey("ID_Produit")]
        public virtual Produit? Produit { get; set; }

        // Méthode pour appliquer le prix courant du produit
        public void AppliquerPrixProduit()
        {
            if (Produit != null)
            {
                PrixUnitaire = Produit.Prix_Produit;
            }
        }
    }
}