using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class listeFournisseur : Form
    {
        List<Fournisseur> fournisseurs = new List<Fournisseur>();
        public listeFournisseur()
        {
            InitializeComponent();
        }

        private void listeFournisseur_Load_1(object sender, EventArgs e)
        {
            setUpTable();
        }
        private void listeFournisseur_FormClosing(object sender, FormClosingEventArgs e)
        {

            GlobalClass.typeOp = 0;

        }



        private void add_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 0;
            ActionToDo();
            setUpTable();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 1;
            ActionToDo();
            setUpTable();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 2;
            ActionToDo();
            setUpTable();
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
                  
                    var fournisseurAmodfier = fournisseurs.Find(f => f.Id == fournisseurId);
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

        private void setUpTable()
        {
            fournisseurs= DataBase.DataBaseMethods.GestionnaireProRetreivingMethods.GetAllFournisseurs();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = fournisseurs;
        }
        

       
    }


}
