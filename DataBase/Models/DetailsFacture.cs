using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    public class DetailsFacture
    {
        public int Id { get; set; }
        public string codeBarre { get; set; }
        public string nom { get; set; }
        public string Type { get; set; }
        public float Quantité { get; set; }
        public float prixAchat { get; set; }
        public float prixVente { get; set; }
        public float remise { get; set; }

        public int factureId { get; set; }
        public Facture facture { get; set; }
    }
}
