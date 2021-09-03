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
            foreach (Control btns in panel1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control btns in panel2.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;



        }



        private void ResetTable()
        {
            _mesFournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs().Result;
            SetUpTable();
        }
        private void TableFournisseur_Load_1(object sender, EventArgs e)
        {
            ResetTable();
        }
        private void TableFournisseur_FormClosing(object sender, FormClosingEventArgs e)
        {

            GlobalClass.typeOp = 0;

        }



        private void add_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 0;
            ActionToDo();
            ResetTable();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 1;
            ActionToDo();
            ResetTable();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 2;
            ActionToDo();
            ResetTable();
        }
        private void ActionToDo()
        {
            int fournisseurId = default;
           if (dataGridView1.RowCount>0)
             fournisseurId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

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
                    var selectedRows = dataGridView1.SelectedRows;
                    if (selectedRows.Count > 0)
                    {
                        foreach (var row in selectedRows)
                        {
                            DataBase.DataBaseMethods.GestionnaireProModifyDeleteMethods.DeleteFournisseur(fournisseurId);
                        }
                        MessageBox.Show("Les Fournisseurs ont été Supprimé avec Succée");
                    }
                    else
                    {
                        DataBase.DataBaseMethods.GestionnaireProModifyDeleteMethods.DeleteFournisseur(fournisseurId);
                        
                    }
                    
                    
                    break;
            }
           
        }

        private void SetUpTable()
        {
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _mesFournisseurs;
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
