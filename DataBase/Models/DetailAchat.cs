using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class DetailAchat
    {
        public int Id { get; set; }
        public string codeBarre { get; set; }
        public string? typeArticle { get; set; }
        public string nom { get; set; }
        public int qnt { get; set; }
        public decimal prixAchat { get; set; }
        public decimal prixVente { get; set; }
        public DateTime? dateExpiration { get; set; }
       
        public int AchatId { get; set; }
        public Achat Achat { get; set; }

        public int? FournisseurId { get; set; }
        public Fournisseur fournisseur { get; set; }
    }
}
