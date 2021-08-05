using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class ActionEffectuer
    {
        public int Id { get; set; }
        public string nomUtilisateur { get; set; }
        public string descriptionAction { get; set; }
        public DateTime dateAction { get; set; }
    }
}
