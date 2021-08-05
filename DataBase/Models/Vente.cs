using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class Vente
    {

        public int Id { get; set; }
        public DateTime dateVente { get; set; }
        public float montantTotale { get; set; }
        public float remise { get; set; }
        public float netPayé { get; set; }
        public string ajouterPar { get; set; }
        public DateTime? dateModification { get; set; }
        public string? modifierPar { get; set; }
       
        public float? nouveauMontantTotal { get; set; }
        public float? nouvelleRemise { get; set; }
        public float? nouveauNetAPayé { get; set; }

        public ICollection<DetailVente> detailVente { get; set; } = new List<DetailVente>();

        public int? clientId { get; set; }
        public Client Client { get; set; }
    }
    
}
