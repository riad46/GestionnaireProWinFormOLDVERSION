using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class DetailCreditClient
    {
        public int Id { get; set; }
        public string descriptionCredit { get; set; }
        public decimal prixTotal { get; set; }
        public decimal restApaye { get; set; }
        public DateTime date { get; set; }
        public bool estPayé { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
