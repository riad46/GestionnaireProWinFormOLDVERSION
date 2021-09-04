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
    public partial class tableClient : Form
    {
        private List<Client> _mesClients = new List<Client>();
        private List<DetailCreditClient> mesDetailsClient = new List<DetailCreditClient>();
        public tableClient()
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
            _mesClients = GestionnaireProRetreivingMethods.GetAllClients().Result;

        }
        private void RefreshClientTable()
        {
            GetAllClients();
            SetUpClientTable();
        }
        private void RefreshDetailsTable()
        {
            SearchClientDetails();
            SetUpDetailsTable();
           
        }
        private int GetCurrentSelectedTableRowIdId()
        {
            if(clientTable.Rows.Count>0)
            return (int)clientTable.SelectedRows[0].Cells[0].Value;
            return default;
        }
        private void SearchForClients(string nom, string numTlf)
        {
            _mesClients = GestionnaireProRetreivingMethods.GetClientsByFilter(nom, numTlf).Result;
        }
        private void SearchClientDetails()
        {
            var SelectedRow_ClientId = GetCurrentSelectedTableRowIdId();
            mesDetailsClient = GestionnaireProRetreivingMethods.GetDetailsCreditClient(SelectedRow_ClientId).Result;
        }
        
        
        private void SetUpClientTable()
        {
            clientTable.AutoGenerateColumns = false;
            clientTable.DataSource = _mesClients;
            clientTable.Refresh();
        }
        private void SetUpDetailsTable()
        {
            detailsTable.AutoGenerateColumns = false;
            detailsTable.DataSource = mesDetailsClient;
            detailsTable.Refresh();
        }

        private void nom_txt_TextChanged(object sender, EventArgs e)
        {
            SearchForClients(nom_txt.Text, numTlf_txt.Text);
            SetUpClientTable();
        }

        private void numTlf_txt_TextChanged(object sender, EventArgs e)
        {
            SearchForClients(nom_txt.Text, numTlf_txt.Text);
            SetUpClientTable();
        }

        private void tableClient_Load(object sender, EventArgs e)
        {
            RefreshClientTable();
           
            
        }

        private void tableCl_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
          
        }

        private void tableCl_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SearchClientDetails();
            SetUpDetailsTable();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 0;
            using (var c=new ajouteClient())
            {
                c.ShowDialog();
                RefreshClientTable();
            }
        }

        private void Modify_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 1;
            var client = _mesClients.Find(c => c.Id == GetCurrentSelectedTableRowIdId());
            using (var c = new ajouteClient(client))
            {
                c.ShowDialog();
                RefreshClientTable();
                RefreshDetailsTable();
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            GestionnaireProModifyDeleteMethods.DeleteClient(GetCurrentSelectedTableRowIdId());
            RefreshClientTable();
            RefreshDetailsTable();
        }
    }
}
