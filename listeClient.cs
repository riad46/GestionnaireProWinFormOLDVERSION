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
        }
        private void GetAllClients()
        {
            mesClients = GestionnaireProRetreivingMethods.GetAllClients().Result;
            
        }
        private void SearchForClients(string nom,string numTlf)
        {
            mesClients= GestionnaireProRetreivingMethods.GetClientsByFilter(nom, numTlf).Result;
        }
        private void SetUpTable()
        {
            tableClient.AutoGenerateColumns = false;
            tableClient.DataSource = mesClients;
            tableClient.Refresh();
        }
        private void listeClient_Load(object sender, EventArgs e)
        {
            GetAllClients();
            SetUpTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchForClients(nom_txt.Text,numTlf_txt.Text);
            SetUpTable();
        }

        private void numTlf_txt_TextChanged(object sender, EventArgs e)
        {
            SearchForClients(nom_txt.Text, numTlf_txt.Text);
            SetUpTable();
        }
        private int GetCurrentSelectedTableRowIdId()
        {
            var row = tableClient.SelectedRows[0];
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
