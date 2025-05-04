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

        public int ID_Client { get; set; }
        public virtual Client? Client { get; set; }

        public virtual ICollection<Details_Commande>? Details_Commandes { get; set; }
    }

}
