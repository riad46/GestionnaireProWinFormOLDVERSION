using Gestionnaire_Pro.DataBase.DataBaseMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    
    public partial class historiqueVente : Form
    {
        private List<DataBase.Models.Vente> _myTableData = null;
        public historiqueVente()
        {
            InitializeComponent();
        }
        private void SetUpTable()
        {
           _myTableData=  GestionnaireProRetreivingMethods.GetHistoriqueDeVente().Result;
            historique_Table.DataSource = _myTableData;
      
            int i = 0;
            foreach (var item in _myTableData)
            {
                historique_Table.Rows[i].Cells[6].Value = item.Client.nom;

            }
        }
        private void historiqueVente_Load(object sender, EventArgs e)
        {
            SetUpTable();
        }

        private void historiqueVente_Resize(object sender, EventArgs e)
        {
            historique_Table.Width = this.Width;
            historique_Table.Height = this.Height - panel1.Height;
        }
    }
}
