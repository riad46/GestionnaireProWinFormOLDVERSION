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
    public partial class tableArticle : Form
    {
        private readonly int fournisseurCell = 8;
        List<Article> articles = new List<Article>();

        public tableArticle()
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


            articleTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            articleTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            articleTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
        }
            private int GetCurrentSelectedTableRowId()
        {
            if(articles.Count>0)
            return (int)articleTable.SelectedRows[0].Cells[0].Value;
            return 0;
        }

        private void DeleteArticle()
        {
            var id = GetCurrentSelectedTableRowId();
            if(id !=0)
            GestionnaireProModifyDeleteMethods.DeleteArticle(id);
        }
        private void DeleteAllArticles()
        {
            GestionnaireProModifyDeleteMethods.DeleteAllArticle();
        }
        private void ResetStock()
        {
            GestionnaireProModifyDeleteMethods.ResetStock();
        }

        private void SetUpTable()
        {
            
           
            articleTable.AutoGenerateColumns = false;
            articleTable.DataSource = articles;

            for (int i = 0; i < articleTable.Rows.Count; i++)
            {
                var monArticle = articles.Find(a => a.Id == (int)articleTable.Rows[i].Cells[0].Value);
                if (monArticle.Fournisseur?.nom != null)
                    articleTable.Rows[i].Cells[fournisseurCell].Value = monArticle.Fournisseur?.nom;
              


            }




        }
        private void ActionToDo()
        {
            switch (GlobalClass.typeOp)
            {
                case 0:
                    using (var addArticleForm= new ajouteArticle())
                    {
                        addArticleForm.ShowDialog();
                    }
                    break;
                case 1:
                    using (var addArticleForm = new ajouteArticle(articles.Find(a=>a.Id == GetCurrentSelectedTableRowId())))
                    {
                        addArticleForm.ShowDialog();
                    }
                    break;
                case 2://delete
                    DeleteArticle();
                    break;
                case 3://deleteAll
                    DeleteAllArticles();
                    break;
                case 4: //reset Stock
                    ResetStock();
                    
                    
                    break;
                default:
                    break;
            }
            articles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
            SetUpTable();
        }
        private void tableArticle_Load(object sender, EventArgs e)
        {
            articles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
            SetUpTable();
            var descriptionAction = $"{GlobalClass.username} a Entrée dans Table Article !!";
            GlobalClass.AddAction(descriptionAction);
        }


       

        private void add_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 0;
            ActionToDo();
           
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 1;
            ActionToDo();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 2;
            ActionToDo();
        }

        private void deleteAll_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 3;
            if (GlobalClass.isSuperAdmin)
            {
                ActionToDo();
            }
            else
            {
                MessageBox.Show("You are not Authorized");
            }
        }

        private void reset_Stock_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 4;
            if (GlobalClass.isSuperAdmin)
            {
                ActionToDo();
            }
            else
            {
                MessageBox.Show("You are not Authorized");
            }
            
        }


        private void SearchForArticlesWithFilers(string codeBarre, string nomArticle, string typeArticle, string nomF)
        {
            if (string.IsNullOrEmpty(codeBarre)) codeBarre = null;
            if (string.IsNullOrEmpty(nomF)) nomF = null;
            if (string.IsNullOrEmpty(nomArticle)) nomArticle = null;
            if (string.IsNullOrEmpty(typeArticle)) typeArticle = null;

            articles = GestionnaireProRetreivingMethods.SearchForArticle(codeBarre, nomArticle, typeArticle, nomF).Result;
            SetUpTable();
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            var codeBarre = codeBarre_txt.Text.Trim();
            var nomArticle = nomArticle_txt.Text.Trim();
            var typeArticle = type_txt.Text.Trim();
            var nomF = nomF_txt.Text.Trim();

            if (codeBarre == "" && nomArticle == "" && typeArticle == "" && nomF == "")
            {
                articles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
                SetUpTable();
            }

            SearchForArticlesWithFilers(codeBarre, nomArticle, typeArticle, nomF);









        }
    }
}
