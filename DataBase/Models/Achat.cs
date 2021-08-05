using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class Achat
    {
        public int Id { get; set; }
        public DateTime dateAchat { get; set; }
        public decimal montantTotal { get; set; }

        public ICollection<DetailAchat> DetailAchats { get; set; } = new List<DetailAchat>();
    }
}
