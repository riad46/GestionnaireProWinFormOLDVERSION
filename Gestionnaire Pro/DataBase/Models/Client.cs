using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class Client
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string? Address { get; set; }
        public string? numTlf { get; set; }
        public decimal credit { get; set; }
        public ICollection<Vente>? Ventes { get; set; } = new List<Vente>();
        public ICollection<DetailCreditClient>? DetailCreditClients { get; set; } = new List<DetailCreditClient>();
    }
}
