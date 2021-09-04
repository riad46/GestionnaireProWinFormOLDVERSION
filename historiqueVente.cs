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
        private List<DataBase.Models.Vente> _myTableData = new List<DataBase.Models.Vente>();
        private int clientID = -1;
        public historiqueVente()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (var panel in Controls)
            {
                if (panel.GetType() == new Panel().GetType())
                    ((Panel)panel).BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.2); ;
            }

            //  historiqueTable.Font =;

            historiqueTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            historiqueTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            historiqueTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;

        }
        private void SearchForHistoriqueVentes()
        {
            _myTableData = GestionnaireProRetreivingMethods.GetHistoriqueDeVenteByFilter(-1,-1,-1,default,DateTime.Now).Result;
            _myTableData.Reverse();
            SetUpTable();
        }
        private void SetUpTable()
        {
            historiqueTable.AutoGenerateColumns = false;
            historiqueTable.DataSource = _myTableData;        
                int i = 0;
                foreach (var item in _myTableData)
                {
                    if(item.Client!=null)
                    historiqueTable.Rows[i].Cells[6].Value = item.Client.nom;

                }
            //historiqueTable.Refresh();
            
        }
      
        private void historiqueVente_Shown(object sender, EventArgs e)
        {
            var datemin =  DateTime.Now;
            dateMin_box.Value = new DateTime(datemin.Year,datemin.Month,datemin.Day,00,00,00);
            dateMax_box.Value = DateTime.Now;
            SearchForHistoriqueVentes();
        }

        private void SetValueToFilter(out float total,out int id,out DateTime dateMin,out DateTime dateMax) 
        {
            id = -1;
            total = -1;

            if(!string.IsNullOrEmpty( id_txt.Text) && !string.IsNullOrWhiteSpace(id_txt.Text))
             id = Convert.ToInt32(id_txt.Text);        

            if (!string.IsNullOrEmpty(total_txt.Text) && !string.IsNullOrWhiteSpace(total_txt.Text))
                total = Convert.ToSingle(total_txt.Text);


            dateMin = dateMin_box.Value;
            dateMax = dateMax_box.Value;

        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            float total;
            int Id;

            DateTime dateMin = default ;
            DateTime dateMax=DateTime.Now;

            SetValueToFilter(out total,out Id,out dateMin,out dateMax);
            
            if(id_txt.Text.Trim() !="" || total_txt.Text.Trim() !="" || nomClient_txt.Text.Trim()!="")
            {
                _myTableData = GestionnaireProRetreivingMethods.GetHistoriqueDeVenteByFilter(Id, clientID, total,default,DateTime.Now).Result;
                _myTableData.Reverse();

                SetUpTable();
                return;
                
            }
            SearchForHistoriqueVentes();

        }



        private void historique_Table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var venteId = (int)historiqueTable[idCol.Index,historiqueTable.SelectedRows[0].Index].Value;
            using (var f=new vente(venteId))
            {
                GlobalClass.typeOp = 1;
                this.Visible = false;
                f.ShowDialog();
                this.Visible = true;
            }
        }

        private void id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, id_txt);
        }

        private void total_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, id_txt);
        }
    }
}
