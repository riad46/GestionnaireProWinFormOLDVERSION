using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class InfoBoutique
    {
        public int Id { get; set; }
        public string? nomBoutique { get; set; }
        public string? address { get; set; }
        public string? numTlf { get; set; }
        public byte[]? logo { get; set; } = null;
       
    }
}
