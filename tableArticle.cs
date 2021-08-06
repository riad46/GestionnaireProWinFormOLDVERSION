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
        }

        private int GetCurrentSelectedTableRowId()
        {
            return (int)articleTable.SelectedRows[0].Cells[0].Value;
        }

        private void DeleteArticle()
        {
            var id = GetCurrentSelectedTableRowId();
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

        private void setUpTable()
        {
            
            articles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
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
            setUpTable();
        }
        private void tableArticle_Load(object sender, EventArgs e)
        {
            setUpTable();
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
            ActionToDo();
        }

        private void reset_Stock_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 4;
            ActionToDo();
        }
    }
}
