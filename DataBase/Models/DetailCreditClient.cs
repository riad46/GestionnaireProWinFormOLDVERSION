using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
   public class DetailCreditClient
    {
        public int Id { get; set; }
        public string descriptionProduit { get; set; }
        public float prixTotale { get; set; }
        public float restApayé { get; set; }
        public DateTime dateCredit { get; set; }
        public bool estPayé { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
