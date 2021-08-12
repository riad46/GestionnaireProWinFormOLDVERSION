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
    public partial class ListFournisseurs : Form
    {
        private List<Fournisseur> _mesFournisseurs = new List<Fournisseur>();
        public ListFournisseurs()
        {
            InitializeComponent();
        }
        private void SetUpTable()
        {
            fournisseurTable.AutoGenerateColumns = false;
            fournisseurTable.DataSource = _mesFournisseurs;
            fournisseurTable.Refresh();

        }
        private void ListFournisseurs_Load(object sender, EventArgs e)
        {
            _mesFournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs();
            SetUpTable();
        }
    }
}
