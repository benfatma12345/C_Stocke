using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Stocke.Entities
{
    public class Utilisateur
    {
        [Key]
        public string? NomUtilisateur { get; set; }
        public string? Mot_De_Passe { get; set; }
    }

}
