using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class Utilisateur
    {
        public int Id { get; set; }
        public string nomUtilisateur { get; set; }
        public string motDePass { get; set; }
        public string numTlf { get; set; }
        public bool estAdmin { get; set; }
    }
}
