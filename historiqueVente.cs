using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
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
        private List<Vente> _myTableData = new List<Vente>();
        private int clientID = -1;
        private readonly int _clientNameIndex = 5;
        private DateTime _dateMin=default;
        private DateTime _dateMax = DateTime.Now;
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
            _myTableData = GestionnaireProRetreivingMethods.GetHistoriqueDeVenteByFilter(-1,-1,-1,_dateMin,_dateMax).Result;
            _myTableData.Reverse();
            SetUpTable();
            SetUpClientsInCells();
            

        }
        private void SetUpClientsInCells()
        {
            int i = 1;
            foreach (var item in _myTableData)
            {
                if (item.Client != null)
                {
                    historiqueTable[_clientNameIndex, i].Value = item.Client.nom;
                }

            }
        }
        private void SetUpTable()
        {
            historiqueTable.AutoGenerateColumns = false;
            historiqueTable.DataSource = _myTableData;        
                int i = 0;
            SetUpClientsInCells();
         
            
        }
      
       

        private void SetValueToFilter(out float total,out int id,out DateTime _dateMin,out DateTime _dateMax) 
        {
            id = -1;
            total = -1;

            if(!string.IsNullOrEmpty( id_txt.Text) && !string.IsNullOrWhiteSpace(id_txt.Text))
             id = Convert.ToInt32(id_txt.Text);        

            if (!string.IsNullOrEmpty(total_txt.Text) && !string.IsNullOrWhiteSpace(total_txt.Text))
                total = Convert.ToSingle(total_txt.Text);


            _dateMin = dateMin_box.Value;
            _dateMax = dateMax_box.Value;

        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            float total;
            int Id;

            SetValueToFilter(out total,out Id,out _dateMin,out _dateMax);
            if(id_txt.Text.Trim() !="" || total_txt.Text.Trim() !="" || nomClient_txt.Text.Trim()!="")
            {
                _myTableData = GestionnaireProRetreivingMethods.GetHistoriqueDeVenteByFilter(Id, clientID, total,default,DateTime.Now).Result;
                _myTableData.Reverse();
                SetUpTable();
                SetUpClientsInCells();
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
                f.ShowDialog();
                
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

        private void historiqueVente_Load(object sender, EventArgs e)
        {
            var datemin = DateTime.Now;
            dateMin_box.Value = new DateTime(datemin.Year, datemin.Month, datemin.Day, 00, 00, 00);
            dateMax_box.Value = DateTime.Now;
            SearchForHistoriqueVentes();
        }
    }
}
