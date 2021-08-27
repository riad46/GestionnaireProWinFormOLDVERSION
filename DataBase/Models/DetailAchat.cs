using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class DetailAchat
    {
        public int Id { get; set; }
        public string codeBarre { get; set; }
        public string? Type { get; set; }
        public string nom { get; set; }
        public float Quantité { get; set; }
        public float prixAchat { get; set; }
        public float prixVente { get; set; }
        public DateTime? dateExpiration { get; set; }
       
        public int AchatId { get; set; }
        public Achat Achat { get; set; }

        public int? fournisseurId { get; set; }
        public Fournisseur fournisseur { get; set; }
    }
}
