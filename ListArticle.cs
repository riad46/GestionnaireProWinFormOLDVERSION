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
   
    public partial class ListArticle : Form
    {
        public Article monArticle = null;
        private readonly int _idCell = 0;
        private readonly int _fournisseurCell = 7;
        private readonly int _codeBarreCell =1;
        private readonly int _nomCell = 2;
        private readonly int _qntCell = 3;
        private readonly int _typeCell = 4;
        private readonly int _prixVenteCell = 5;
        
        List<Article> articles = new List<Article>();


        public ListArticle()
        {
            InitializeComponent();
        }

        private void SetUpTable()
        {
            articles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
            articleTable.AutoGenerateColumns = false;
            articleTable.DataSource = articles;

            for (int i = 0; i < articleTable.Rows.Count; i++)
            {
                var monArticle = articles.Find(a => a.Id == (int)articleTable.Rows[i].Cells[0].Value);
                if (monArticle.Fournisseur?.nom != null)
                    articleTable.Rows[i].Cells[_fournisseurCell].Value = monArticle.Fournisseur?.nom;



            }
        }
        private void SetUpArticleToSend()
        {
            monArticle = new Article();
            monArticle.Id = (int)articleTable.SelectedRows[0].Cells[_idCell].Value;
            monArticle.codeBarre = (string)articleTable.SelectedRows[0].Cells[_codeBarreCell].Value;
            monArticle.nom = (string)articleTable.SelectedRows[0].Cells[_nomCell].Value;
            monArticle.prixVente = (float)articleTable.SelectedRows[0].Cells[_prixVenteCell].Value;
            monArticle.type = (string)articleTable.SelectedRows[0].Cells[_typeCell].Value;
            monArticle.quantité = 1;
            monArticle.prixAchat = articles.Find(a => a.Id == monArticle.Id).prixAchat;

            GestionnaireProModifyDeleteMethods.SetArticleQnt(monArticle.Id, (float)articleTable.SelectedRows[0].Cells[_qntCell].Value - 1);
        }
        private void ListArticle_Load(object sender, EventArgs e)
        {
            SetUpTable();
        }

        private void articleTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GlobalClass.typeOp == 10) 
            {
                SetUpArticleToSend();
                Close();
                GlobalClass.typeOp = 0;
            }


        }
    }
}
