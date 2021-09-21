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
    public partial class Notification : Form
    {
        public List<Article> _mesQntArticles { get; set; } = new List<Article>();
        public List<Article> _newAddedQntArticles { get; set; } = new List<Article>();
        public List<Article> _deletedQntArticles { get; set; } = new List<Article>();
        public List<Article> _mesDatesArticles { get; set; } = new List<Article>();
        public List<Article> _newAddedDatesArticles { get; set; } = new List<Article>();
        public List<Article> _deletedDatesArticles { get; set; } = new List<Article>();
        public Notification()
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
            addQntArticle_btn.BackColor = ThemeColor.PrimaryColor;
            addDateArticle_btn.BackColor = ThemeColor.PrimaryColor;
            delQntArticle_btn.BackColor = ThemeColor.PrimaryColor;
            delDateArticle_btn.BackColor = ThemeColor.PrimaryColor;

            qntArticlesTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            qntArticlesTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            qntArticlesTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;

            dateArticlesTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dateArticlesTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            dateArticlesTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
        }
        
        private void SetUpTables()
        {
            //QNT
            var bindingQNTArticlesList = new BindingList<Article>(_mesQntArticles);
            var qntSource = new BindingSource(bindingQNTArticlesList, null);
            qntArticlesTable.AutoGenerateColumns = false;
            qntArticlesTable.DataSource = qntSource;
            //DATE
            var bindingDateArticlesList = new BindingList<Article>(_mesDatesArticles);
            var dateSource = new BindingSource(bindingDateArticlesList, null);
            dateArticlesTable.AutoGenerateColumns = false;
            dateArticlesTable.DataSource = dateSource;

        }
        private void GetTablesArticles()
        {
            var qntTableIds = GestionnaireProRetreivingMethods.GetQntNONVerifiedProducts().Result;
            var dateTableIds = GestionnaireProRetreivingMethods.GetDateNONVerifiedProducts().Result;
            foreach (var item in qntTableIds)
            {
                _mesQntArticles.Add(GestionnaireProRetreivingMethods.GetArticleById(item.articleId).Result);
            }
            foreach (var item in dateTableIds)
            {
                _mesDatesArticles.Add(GestionnaireProRetreivingMethods.GetArticleById(item.articleId).Result);
            }

            SetUpTables();
        }
        private void SaveSettingsValues()
        {
            Properties.Settings.Default.checkQnt = ActivateQntNotificationSys_CheckBox.Checked;
            Properties.Settings.Default.checkDate = ActivateDateNotificationSys_CheckBox.Checked;
            Properties.Settings.Default.checkDateValue = Convert.ToSingle(days_txt.Text);
            Properties.Settings.Default.checkQntValue = Convert.ToSingle(qnt_txt.Text);
            Properties.Settings.Default.Save();
        }
        private void LoadSettingsValues()
        {
            ActivateQntNotificationSys_CheckBox.Checked = Properties.Settings.Default.checkQnt;
            ActivateDateNotificationSys_CheckBox.Checked = Properties.Settings.Default.checkDate;
            days_txt.Text = Properties.Settings.Default.checkDateValue.ToString();
            qnt_txt.Text = Properties.Settings.Default.checkQntValue.ToString();
         }
        private void SaveArticlesToDataBase()
        {
            var listOfArticlesIdToAddTo_Dates_Db = new List<int>();
            var listOfArticlesIdToAddTo_QNT_Db = new List<int>();
            //SetUp the lists to add IDS to DB 
            foreach (var item in _newAddedDatesArticles)
            {
                var deletedArticleIndex = _deletedDatesArticles.FindIndex(a => a.Id == item.Id);
                if (deletedArticleIndex == -1)
                {
                    listOfArticlesIdToAddTo_Dates_Db.Add(item.Id);
                }
                else
                {
                    _deletedDatesArticles.RemoveAt(deletedArticleIndex);
                }
            }
            foreach (var item in _newAddedQntArticles)
            {
                var deletedArticleIndex = _deletedQntArticles.FindIndex(a => a.Id == item.Id);
                if (deletedArticleIndex == -1)
                {
                    listOfArticlesIdToAddTo_QNT_Db.Add(item.Id);
                }
                else
                {
                    _deletedQntArticles.RemoveAt(deletedArticleIndex);
                }
            }

            //remove the article that are removed from the Table
            foreach (var item in _deletedDatesArticles)
            {
                GestionnaireProModifyDeleteMethods.DeleteArticleFromDateCheck(item.Id);
            }
            foreach (var item in _deletedQntArticles)
            {
                GestionnaireProModifyDeleteMethods.DeleteArticleFromQntCheck(item.Id);
            }
            //Add the new Added Ids
            GestionnaireProInsertingMethods.AddDateVerifiedProducts(listOfArticlesIdToAddTo_Dates_Db);
            GestionnaireProInsertingMethods.AddQNTVerifiedProducts(listOfArticlesIdToAddTo_QNT_Db);
        }
        private void Notification_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsValues();
            SaveArticlesToDataBase();
        }
        private void Notification_FormLoad(object sender, EventArgs e)
        {
            LoadSettingsValues();
            GetTablesArticles();
        }
        private void days_txt_Leave(object sender, EventArgs e)
        {
            if (days_txt.Text.Trim().Length == 0)
                days_txt.Text = "0";
        }
        private void qnt_txt_TextChanged(object sender, EventArgs e)
        {
            if (qnt_txt.Text.Trim().Length == 0)
                qnt_txt.Text = "0";
        }
        
        private void qnt_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, qnt_txt);
        }
        private void days_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, days_txt);
        }
        
        private void addQntArticle_btn_Click(object sender, EventArgs e)
        {
            using (var listArticleForm=new ListArticle(1))
            {
                GlobalClass.typeOp = 10;
                listArticleForm.ShowDialog();
                if (listArticleForm.monArticle.codeBarre != null)
                {
                    if (_mesQntArticles.FindIndex(a => a.Id == listArticleForm.monArticle.Id) == -1)
                    {
                        _mesQntArticles.Add(listArticleForm.monArticle);
                        _newAddedQntArticles.Add(listArticleForm.monArticle);
                        SetUpTables();
                    }
                    
                }
                
            }
        }
        private void addDateArticle_btn_Click(object sender, EventArgs e)
        {
            using (var listArticleForm = new ListArticle(1))
            {
                GlobalClass.typeOp = 10;
                listArticleForm.ShowDialog();
                if (listArticleForm.monArticle.codeBarre != null)
                {
                    if (_mesDatesArticles.FindIndex(a => a.Id == listArticleForm.monArticle.Id) == -1)
                    {
                        _mesDatesArticles.Add(listArticleForm.monArticle);
                        _newAddedDatesArticles.Add(listArticleForm.monArticle);
                        SetUpTables();
                    }
                        
                }

            }
        }

        private void delDateArticle_btn_Click(object sender, EventArgs e)
        {
            var selectedIndex = dateArticlesTable.SelectedRows[0].Index;
            if (selectedIndex <0) return;
            _deletedDatesArticles.Add(_mesDatesArticles[selectedIndex]);
            _mesDatesArticles.RemoveAt(selectedIndex);
            SetUpTables();
        }

        private void delQntArticle_btn_Click(object sender, EventArgs e)
        {
            var selectedIndex = qntArticlesTable.SelectedRows[0].Index;
            if (selectedIndex < 0) return;
            _deletedQntArticles.Add(_mesQntArticles[selectedIndex]);
            _mesQntArticles.RemoveAt(selectedIndex);
            SetUpTables();
        }
    }
}
