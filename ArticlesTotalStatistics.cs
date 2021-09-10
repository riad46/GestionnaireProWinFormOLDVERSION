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
    public partial class ArticlesTotalStatistics : Form
    {
        private readonly int _totalAchatIndex = 7;
        private readonly int _totalVenteIndex = 8;
        private readonly int _revenueNetIndex = 9;
        List<Article> _articles = new List<Article>();

        public ArticlesTotalStatistics()
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
        private void SetUpTable()
        {

            articleTable.AutoGenerateColumns = false;
            articleTable.DataSource = _articles;

            for(int i = 0; i < _articles.Count; i++)
            {
                articleTable[_totalAchatIndex, i].Value = _articles[i].prixAchat * _articles[i].quantité;
                articleTable[_totalVenteIndex, i].Value = _articles[i].prixVente * _articles[i].quantité;
                articleTable[_revenueNetIndex, i].Value = (_articles[i].prixVente * _articles[i].quantité)-(_articles[i].prixAchat * _articles[i].quantité);
            }
        }
        private void ArticlesTotalStatistics_Load(object sender, EventArgs e)
        {

            _articles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
            SetUpTable();
            var descriptionAction = $" a Entrée dans Revenue Total Article ...................";
            GlobalClass.AddAction(GlobalClass.username, descriptionAction);
        }

        private void SearchForArticlesWithFilers(string codeBarre, string nomArticle, string typeArticle, string nomF)
        {
            if (string.IsNullOrEmpty(codeBarre)) codeBarre = null;
            if (string.IsNullOrEmpty(nomF)) nomF = null;
            if (string.IsNullOrEmpty(nomArticle)) nomArticle = null;
            if (string.IsNullOrEmpty(typeArticle)) typeArticle = null;

            _articles = GestionnaireProRetreivingMethods.SearchForArticle(codeBarre, nomArticle, typeArticle, nomF).Result;
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
                _articles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
                SetUpTable();
            }

            SearchForArticlesWithFilers(codeBarre, nomArticle, typeArticle, nomF);

        }
    }
}
