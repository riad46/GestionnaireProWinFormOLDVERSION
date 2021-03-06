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
    public partial class listeClient : Form
    {
        private List<Client> mesClients = new List<Client>();
        public listeClient()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control pan in Controls)
            {
                pan.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.2);
            }

           
            clientTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            clientTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            clientTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;




        }
        private void GetAllClients()
        {
            mesClients = GestionnaireProRetreivingMethods.GetAllClients().Result;
            
        }
        private void SearchForClients(string numRegistre,string nom,string numTlf)
        {
            mesClients= GestionnaireProRetreivingMethods.GetClientsByFilter(numRegistre,nom, numTlf).Result;
        }
        private void SetUpTable()
        {
            clientTable.AutoGenerateColumns = false;
            clientTable.DataSource = mesClients;
            clientTable.Refresh();
        }
        private void listeClient_Load(object sender, EventArgs e)
        {
            GetAllClients();
            SetUpTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchForClients(numRegistre_txt.Text.Trim(),nom_txt.Text.Trim(),numTlf_txt.Text.Trim());
            SetUpTable();
        }

        private void numTlf_txt_TextChanged(object sender, EventArgs e)
        {
            SearchForClients(numRegistre_txt.Text.Trim(), nom_txt.Text.Trim(), numTlf_txt.Text.Trim());
            SetUpTable();
        }
        private void numRegistre_txt_TextChanged(object sender, EventArgs e)
        {
            SearchForClients(numRegistre_txt.Text.Trim(), nom_txt.Text.Trim(), numTlf_txt.Text.Trim());
            SetUpTable();
        }

        private int GetCurrentSelectedTableRowIdId()
        {
            var row = clientTable.SelectedRows[0];
            return (int)row.Cells[0].Value;
        }
        private void tableClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var c = new ajoutCreditDetail(GetCurrentSelectedTableRowIdId()))
            {
                GlobalClass.typeOp = 1;
                c.ShowDialog();
            }
        
               
           
        }

     
    }
}
