using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace Gestionnaire_Pro.DataBase.Models
{
    public class Article
    {
       
        public int Id { get; set; }
        public string codeBarre { get; set; }
        public string? type { get; set; }
        public string nom { get; set; }
        public float quantité { get; set; }
        public float prixAchat { get; set; }
        public float prixVente { get; set; }
        public DateTime? dateExpiration { get; set; }
        public int? FournisseurId { get; set; } = null;
        public Fournisseur Fournisseur { get; set; }

       
    }
}
