using System;
using System.Collections.Generic;
using System.Text;

namespace Gestionnaire_Pro.DataBase.Models
{
    class ArticleExcluAnotification
    {
        public int Id { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

    }
}
