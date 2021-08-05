using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    public class Fournisseur
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string? Address { get; set; }
        public string? numTlf { get; set; }
        public float creditArendre { get; set; }

        public ICollection<Article> Articles { get; set; } = new List<Article>();

    }
}
