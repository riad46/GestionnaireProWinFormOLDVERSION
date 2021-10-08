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
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control pan in Controls)
            {
                pan.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor,0.2);
            }
           
            //fournisseurTable.EnableHeadersVisualStyles = false;
            fournisseurTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            fournisseurTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            fournisseurTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;




        }
        private void SetUpTable()
        {
            fournisseurTable.AutoGenerateColumns = false;
            fournisseurTable.DataSource = _mesFournisseurs;
            fournisseurTable.Refresh();

        }
        private void ListFournisseurs_Load(object sender, EventArgs e)
        {
            _mesFournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs().Result;
            SetUpTable();
        }

        private void SearchForFournisseur(string nom,string numTlf,float credit)
        {
            _mesFournisseurs=GestionnaireProRetreivingMethods.SearchForFournisseur(nom, numTlf, credit).Result;
            SetUpTable();
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            var nom = nom_txt.Text.Trim();
            var numTlf = num_txt.Text.Trim();
            float credit=-1;
            if(!string.IsNullOrEmpty( credit_txt.Text.Trim()))
            credit = Convert.ToSingle(credit_txt.Text);
           
           
            SearchForFournisseur(nom, numTlf, credit);
        }

        private void credit_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e,credit_txt);
        }
    }
}
