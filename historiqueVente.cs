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
            historique_Table.AutoGenerateColumns = false;
          
            historique_Table.DataSource = _myTableData;

           
                int i = 0;
                foreach (var item in _myTableData)
                {
                    if(item.Client!=null)
                    historique_Table.Rows[i].Cells[6].Value = item.Client.nom;

                }
            historique_Table.Refresh();
            
        }
      
        private void historiqueVente_Shown(object sender, EventArgs e)
        {
            _myTableData = GestionnaireProRetreivingMethods.GetHistoriqueDeVente().Result;
            SetUpTable();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
          //  var id = Convert.ToInt32(id_txt.Text);
            var clientId =0;
        //    var total = Convert.ToSingle(total_txt.Text);
            var dateMin = Convert.ToDateTime(datemin_txt.Text);
            var dateMax = Convert.ToDateTime(datemax_txt.Text);
            _myTableData=GestionnaireProRetreivingMethods.GetHistoriqueDeVenteByFilter(-1,-1,-1,dateMin,dateMax).Result;
            SetUpTable();
            
        }
    }
}
