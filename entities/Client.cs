using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Stocke.Entities
{
    public class Client
    {
        [Key]
        public int ID_Client { get; set; }
        public string? Nom_Client { get; set; }
        public string? Prenom_Client { get; set; }
        public string? Adresse_Client { get; set; }
        public string? Telephone_Client { get; set; }
        public string? Pays_Client { get; set; }
        public string? Ville_Client { get; set; }
        public string? Email_Client { get; set; }

        public virtual ICollection<Commande>? Commandes { get; set; }
    }

}
