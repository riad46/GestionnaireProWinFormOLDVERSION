using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public DateTime dateFacture { get; set; }
        public float montantTotale { get; set; }
        public float remise { get; set; }
        public float netPayé { get; set; }
        public string ajouterPar { get; set; }
       
        public ICollection<DetailVente> detailsFacture { get; set; } = new List<DetailVente>();

        public int? clientId { get; set; }
        public Client Client { get; set; }
    }
}
