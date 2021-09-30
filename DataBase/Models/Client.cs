using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string numRegistre { get; set; }
        public string nom { get; set; }
        public string? address { get; set; }
        public string? numTlf { get; set; }
        public float credit { get; set; }
        public ICollection<Vente>? Ventes { get; set; } = new List<Vente>();
        public ICollection<DetailCreditClient>? DetailCreditClients { get; set; } = new List<DetailCreditClient>();
    }
}
