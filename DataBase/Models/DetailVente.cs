using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class DetailVente
    {
        public int Id { get; set; }
        public string codeBarre { get; set; }
        public string nomArticle { get; set; }
        public string typeArticle { get; set; }
        public float qnt { get; set; }
        public float prixAchat{ get; set; }
        public float prixVente { get; set; }
        public float remise { get; set; }
        public float nouvelleQnt { get; set; }
        public float nouvelleRemise { get; set; }
        public float nouveauTotal { get; set; }
       
        public int VenteId { get; set; }
        public Vente Vente { get; set; }
        

    }
}
