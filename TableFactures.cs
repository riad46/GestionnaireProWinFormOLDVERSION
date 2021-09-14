﻿using Gestionnaire_Pro.DataBase.DataBaseMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class TableFactures : Form
    {
        private List<DataBase.Models.Facture> _myTableData = new List<DataBase.Models.Facture>();
        private int clientID = -1;
        private readonly int _clientNameIndex = 5;
        private DateTime _dateMin = default;
        private DateTime _dateMax = DateTime.Now;
        public TableFactures()
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
            foreach (var item in _myTableData)
            {
                if (item.Client != null)
                    historiqueTable.Rows[i].Cells[6].Value = item.Client.nom;

            }
            

        }
        private void SearchForHistoriqueVentes()
        {
            _myTableData = GestionnaireProRetreivingMethods.GetFacturesByFilter(-1, -1, -1, _dateMin, _dateMax).Result;
            _myTableData.Reverse();
            SetUpTable();
            SetUpClientsInCells();
        }
        private void TableFactureForm_Shown(object sender, EventArgs e)
        {
            var datemin = DateTime.Now;
            dateMin_box.Value = new DateTime(datemin.Year, datemin.Month, datemin.Day, 00, 00, 00);
            dateMax_box.Value = DateTime.Now;
            SearchForHistoriqueVentes();
        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            float total;
            int Id;



            SetValueToFilter(out total, out Id, out _dateMin, out _dateMax);

            if (id_txt.Text.Trim() != "" || total_txt.Text.Trim() != "" || nomClient_txt.Text.Trim() != "")
            {
                _myTableData = GestionnaireProRetreivingMethods.GetFacturesByFilter(Id, clientID, total, default, DateTime.Now).Result;
                _myTableData.Reverse();
                SetUpTable();
                SetUpClientsInCells();
                return;

            }
            SearchForHistoriqueVentes();
        }
        private void SetValueToFilter(out float total, out int id, out DateTime _dateMin, out DateTime _dateMax)
        {
            id = -1;
            total = -1;

            if (!string.IsNullOrEmpty(id_txt.Text) && !string.IsNullOrWhiteSpace(id_txt.Text))
                id = Convert.ToInt32(id_txt.Text);

            if (!string.IsNullOrEmpty(total_txt.Text) && !string.IsNullOrWhiteSpace(total_txt.Text))
                total = Convert.ToSingle(total_txt.Text);


            _dateMin = dateMin_box.Value;
            _dateMax = dateMax_box.Value;

        }
        private void historique_Table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, id_txt);
        }
        private void total_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, id_txt);
        }
        private void del_btn_Click(object sender, EventArgs e)
        {
            DeleteCurrentSelectedRow();
        }
        private int GetCurrentSelectedTableRowId(int myRow)
        {
            
                if (historiqueTable.RowCount > 0)
                    return (int)historiqueTable[idCol.Index,myRow].Value;
                return -1;
           
        }
        private void DeleteCurrentSelectedRow()
        {

            var myRow = historiqueTable.SelectedRows[0].Index;
            if (myRow == -1) return;

            var factureId = GetCurrentSelectedTableRowId(myRow);
            GestionnaireProModifyDeleteMethods.DeleteFacture(factureId);


            var maFactureIndex = _myTableData.FindIndex(a => a.Id == factureId);
            _myTableData.RemoveAt(maFactureIndex);
            SetUpTable();
        }

        
    }
}

