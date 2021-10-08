using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class TableFournisseur : Form
    {
        List<Fournisseur> _mesFournisseurs = new List<Fournisseur>();
        public TableFournisseur()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (var item in Controls)
            {
                if(item.GetType()==new Panel().GetType())
                ((Panel)item).BackColor =ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor,0.2);
            }
            
            //fournisseurTable.EnableHeadersVisualStyles = false;
            fournisseurTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            fournisseurTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            fournisseurTable.ColumnHeadersDefaultCellStyle.SelectionBackColor= ThemeColor.PrimaryColor; 
            



        }



        private void ResetTable()
        {
            _mesFournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs().Result;
            SetUpTable();
        }
        private void TableFournisseur_Load_1(object sender, EventArgs e)
        {
            ResetTable();
            var descriptionAction = $" Entrée dans Table Fournisseur";
            GlobalClass.AddAction(GlobalClass.username,descriptionAction);
        }
        private void TableFournisseur_FormClosing(object sender, FormClosingEventArgs e)
        {

            GlobalClass.typeOp = 0;

        }



        private void add_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 0;
            ActionToDo();
         
        }
        private void modify_btn_Click(object sender, EventArgs e)
        {
            if (fournisseurTable.RowCount <= 0)
                return;
            GlobalClass.typeOp = 1;
            ActionToDo();
           
        }
        private void del_btn_Click(object sender, EventArgs e)
        {
            if (fournisseurTable.RowCount <= 0)
                return;
            GlobalClass.typeOp = 2;
            ActionToDo();
          
        }
        private void ActionToDo()
        {
            int fournisseurId = default;

            if (fournisseurTable.RowCount >0)
                
            fournisseurId = (int)fournisseurTable.SelectedRows[0].Cells[0].Value;

            switch (GlobalClass.typeOp)
            {
                case 0:
                    using (ajouteFournisseur frnForm = new ajouteFournisseur())
                    {
                        frnForm.ShowDialog();
                    }
                    break;
                case 1:
                  
                    var fournisseurAmodfier = _mesFournisseurs.Find(f => f.Id == fournisseurId);
                    using (ajouteFournisseur frnForm = new ajouteFournisseur(fournisseurAmodfier))
                    {
                        frnForm.ShowDialog();
                    }
                    break;
                case 2:
                    var selectedRows = fournisseurTable.SelectedRows;
                    if (selectedRows.Count > 0)
                    {
                        foreach (var row in selectedRows)
                        {
                            GestionnaireProModifyDeleteMethods.DeleteFournisseur(fournisseurId);
                        }
                        MessageBox.Show("Les Fournisseurs ont été Supprimé avec Succée");
                    }
                    else
                    {
                     GestionnaireProModifyDeleteMethods.DeleteFournisseur(fournisseurId);
                        
                    }
                    
                    
                    break;
            }
            ResetTable();
           
        }

        private void SetUpTable()
        {
            
            fournisseurTable.AutoGenerateColumns = false;
            fournisseurTable.DataSource = _mesFournisseurs;
        }

        private void SearchForFournisseur(string nom, string numTlf, float credit)
        {
            _mesFournisseurs = GestionnaireProRetreivingMethods.SearchForFournisseur(nom, numTlf, credit).Result;
            SetUpTable();
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            var nom = nom_txt.Text.Trim();
            var numTlf = num_txt.Text.Trim();
            float credit = -1;
            if (!string.IsNullOrEmpty(credit_txt.Text.Trim()))
                credit = Convert.ToSingle(credit_txt.Text);


            SearchForFournisseur(nom, numTlf, credit);
        }

       
    }


}
