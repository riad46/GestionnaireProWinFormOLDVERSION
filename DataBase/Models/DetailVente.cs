using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    public class DetailVente
    {
        public int Id { get; set; }
        public string codeBarre { get; set; }
        public string nom{ get; set; }
        public string Type { get; set; }
        public float Quantité { get; set; }
        public float prixAchat{ get; set; }
        public float prixVente { get; set; }
        public float total { get; set; }
        public float remise { get; set; }
        public float nouvelleQnt { get; set; }
        public float nouvelleRemise { get; set; }
        public float nouveauTotal { get; set; }
       
        public int VenteId { get; set; }
        public Vente Vente { get; set; }
        

    }
}
