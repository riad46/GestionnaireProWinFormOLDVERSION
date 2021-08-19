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
        private int clientID = -1;
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

            var datemin =  DateTime.Now;
            datemin_txt.Text = new DateTime(datemin.Year,datemin.Month,datemin.Day,00,00,00).ToString();
            datemax_txt.Text = DateTime.Now.ToString();
            _myTableData = GestionnaireProRetreivingMethods.GetHistoriqueDeVente().Result;
            SetUpTable();
        }

        private void SetValueToFilter(out float total,out int id,out DateTime dateMin,out DateTime dateMax) 
        {
            id = -1;
            total = -1;

            if(!string.IsNullOrEmpty( id_txt.Text) && !string.IsNullOrWhiteSpace(id_txt.Text))
             id = Convert.ToInt32(id_txt.Text);        

            if (!string.IsNullOrEmpty(total_txt.Text) && !string.IsNullOrWhiteSpace(total_txt.Text))
                total = Convert.ToSingle(total_txt.Text);


             dateMin = Convert.ToDateTime(datemin_txt.Text);
             dateMax = Convert.ToDateTime(datemax_txt.Text);

        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            float total;
            int id;
            
            DateTime dateMin=default;
            DateTime dateMax=DateTime.Now;

            SetValueToFilter(out total,out id,out dateMin,out dateMax);
            if (datemin_txt.Text == "" || datemin_txt.Text == "") return;
            _myTableData=GestionnaireProRetreivingMethods.GetHistoriqueDeVenteByFilter(id,clientID,total,dateMin,dateMax).Result;
            SetUpTable();
            
        }
    }
}
