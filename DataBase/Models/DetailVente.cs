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
        public int qnt { get; set; }
        public decimal prixAchat{ get; set; }
        public decimal prixVente { get; set; }
        public decimal remise { get; set; }
        public int nouvelleQnt { get; set; }
        public decimal nouvelleRemise { get; set; }
        public decimal nouveauTotal { get; set; }
       
        public int VenteId { get; set; }
        public Vente Vente { get; set; }
        

    }
}
