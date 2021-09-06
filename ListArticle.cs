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
        int _achatCall = 0;
        public Article monArticle = new Article();
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
            LoadTheme();
        }
        /// <summary>
        /// if it is called from achat use this  
        /// achat call gives the value 1 to achatCall variable
        /// </summary>
        /// <param name="achatIndex"></param>
        public ListArticle(int achatIndex)
        {
            _achatCall = achatIndex;
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control pan in Controls)
            {
                pan.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.2);
            }


            articleTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            articleTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            articleTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;

        }

        private void SetUpTable()
        {
          
            articleTable.AutoGenerateColumns = false;
            articleTable.DataSource = articles;

            for (int i =0; i < articleTable.Rows.Count; i++)
            {
                var monArticle = articles.Find(a => a.Id == (int)articleTable.Rows[i].Cells[0].Value);
                if (monArticle.Fournisseur != null)
                    articleTable[_fournisseurCell,i].Value = monArticle.Fournisseur.nom;
            }

           
        }
        private void SetUpArticleToSend()
        {
            monArticle.Id = (int)articleTable.SelectedRows[0].Cells[_idCell].Value;
            monArticle.codeBarre = (string)articleTable.SelectedRows[0].Cells[_codeBarreCell].Value;
            monArticle.nom = (string)articleTable.SelectedRows[0].Cells[_nomCell].Value;
            monArticle.prixVente = (float)articleTable.SelectedRows[0].Cells[_prixVenteCell].Value;
            monArticle.type = (string)articleTable.SelectedRows[0].Cells[_typeCell].Value;
            monArticle.quantité = 1;
            monArticle.prixAchat = articles.Find(a => a.Id == monArticle.Id).prixAchat;
           if(articleTable.SelectedRows[0].Cells[6].RowIndex >-1 && articles[articleTable.SelectedRows[0].Cells[6].RowIndex].dateExpiration !=null)
            monArticle.dateExpiration = Convert.ToDateTime(articleTable.SelectedRows[0].Cells[6].Value);
            if (articleTable.SelectedRows[0].Cells[_fournisseurCell].RowIndex > -1 && articles[articleTable.SelectedRows[0].Cells[_fournisseurCell].RowIndex].Fournisseur != null)
            {
                monArticle.Fournisseur = articles[articleTable.SelectedRows[0].Cells[_fournisseurCell].RowIndex].Fournisseur;
            }

            if (_achatCall != 1)
            {
                if ((float)articleTable.SelectedRows[0].Cells[_qntCell].Value > 0)
                {
                    GestionnaireProModifyDeleteMethods.SetArticleQnt(monArticle.Id, (float)articleTable.SelectedRows[0].Cells[_qntCell].Value - 1);

                }
                else
                {
                    MessageBox.Show("Quantité Insuffisante!!");
                    monArticle = null;
                    return;
                }
            }
            

            
        }
        private void ListArticle_Load(object sender, EventArgs e)
        {
            articles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
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
        private void SearchForArticlesWithFilers(string codeBarre,string nomArticle,string typeArticle,string nomF)
        {
            if (string.IsNullOrEmpty(codeBarre)) codeBarre = null;
            if (string.IsNullOrEmpty(nomF)) nomF = null;
            if (string.IsNullOrEmpty(nomArticle)) nomArticle = null;
            if (string.IsNullOrEmpty(typeArticle)) typeArticle = null;

           articles =GestionnaireProRetreivingMethods.SearchForArticle(codeBarre, nomArticle, typeArticle, nomF).Result;
            SetUpTable();
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            var codeBarre = codeBarre_txt.Text.Trim();
            var nomArticle=nomArticle_txt.Text.Trim();
            var typeArticle = type_txt.Text.Trim();
            var nomF = nomF_txt.Text.Trim();

            if(codeBarre=="" &&nomArticle=="" && typeArticle=="" && nomF=="")
            {
                articles = GestionnaireProRetreivingMethods.GetAllArticles().Result; 
                SetUpTable();
            }

            SearchForArticlesWithFilers(codeBarre, nomArticle, typeArticle, nomF);

            
            
            
            
           



        }

      
    }
}
