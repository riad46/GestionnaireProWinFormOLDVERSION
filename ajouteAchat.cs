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
    
    public partial class ajouteAchat : Form
    {
        private List<Article> _mesArticles = new List<Article>();
        private List<Fournisseur> _fournisseurs = new List<Fournisseur>();
        private int _fournisseurCellIndex =8;

        private float _totalPayé=0;

        public ajouteAchat()
        {
            InitializeComponent();
        }

        private void SetUpTable()
        {
            var bindingArticlesList = new BindingList<Article>(_mesArticles);
            var source = new BindingSource(bindingArticlesList, null);

            articleTable.AutoGenerateColumns = false;
            articleTable.DataSource = source;
            articleTable.Refresh();
           
            if (articleTable.RowCount > 0)
                for (int i = 0; i < articleTable.RowCount; i++)
                {
                    if (_mesArticles[i].FournisseurId >0)
                        articleTable.Rows[i].Cells[_fournisseurCellIndex].Value = _fournisseurs.Find(f=>f.Id== _mesArticles[i].FournisseurId).nom;
                }
        }
        private void AddArticleToBoxes(Article article)
        {
            codeBarre_txt.Text = article.codeBarre;
            nom_txt.Text = article.nom;
            type_txt.Text = article.type;
            qnt_txt.Text = "0";
            prixA_txt.Text = "0,0";
            prixV_txt.Text = "0,0";
            if (article.dateExpiration != null && article.dateExpiration !=default)
                dateExp_box.Value = article.dateExpiration.Value;
         
            if(article.Fournisseur !=null )
            fournisseurs_combo.Text = article.Fournisseur.nom;
          

        }
     
        //------------------------------------------------------------------WORK HERE
        private void CleanTheBoxes()
        {
            codeBarre_txt.Text = "";
            nom_txt.Text = "";
            type_txt.Text = "";
           qnt_txt.Text = "";
            prixA_txt.Text = "";
            prixV_txt.Text = "";
            dateExp_box.Value = DateTime.Now;
            fournisseurs_combo.Text = "";
        }
        private void ListArticle_Click(object sender, EventArgs e)
        {
            CleanTheBoxes();
            GlobalClass.typeOp = 10;
            using (var listArticle = new ListArticle())
            {
                listArticle.ShowDialog();
                if (listArticle.monArticle == null) return;
                if (listArticle.monArticle.nom != null)
                {
                    if (_mesArticles.FindIndex(a => a.Id == listArticle.monArticle.Id)!=-1)
                    {
                        MessageBox.Show("Article est déja ajouter dans le Tableau");
                        return;
                    
                    }

                    AddArticleToBoxes(listArticle.monArticle);
                  
                }
            }
        }
        private void FillFournisseursCombo()
        {
            _fournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs().Result;
            foreach (var item in _fournisseurs)
            {
                fournisseurs_combo.Items.Add(item.nom);
            }
        }
        private void ajouteAchat_Load(object sender, EventArgs e)
        {
            qnt_txt.Cursor = default;
            dateAchat_box.Value = DateTime.Now;
            FillFournisseursCombo();
        }

        private void ajoutArticle_btn_Click(object sender, EventArgs e)
        {
            if(_mesArticles.FindIndex(a=>a.nom==nom_txt.Text || a.codeBarre==codeBarre_txt.Text) > -1)
            {
                MessageBox.Show("Article Déja Ajouté dans le Tableau !! vérifier le nom ou codeBarre");
                return;
            }
            int fournisseurId =GestionnaireProRetreivingMethods.GetFournisseurIdByNom(fournisseurs_combo.Text);
            
            if (fournisseurId<1)
            {
                _mesArticles.Add(new Article
                {
                    codeBarre = codeBarre_txt.Text,
                    nom = nom_txt.Text,
                    type = type_txt.Text ,
                    quantité = Convert.ToSingle(qnt_txt.Text),
                    prixAchat = Convert.ToSingle(prixA_txt.Text),
                    prixVente = Convert.ToSingle(prixV_txt.Text),
                    dateExpiration = dateExp_box.Value,
            });

            }
            else
            {
                _mesArticles.Add(new Article
                {
                    codeBarre = codeBarre_txt.Text,
                    nom = nom_txt.Text,
                    type = type_txt.Text,
                    quantité = Convert.ToSingle(qnt_txt.Text),
                    prixAchat = Convert.ToSingle(prixA_txt.Text),
                    prixVente = Convert.ToSingle(prixV_txt.Text),
                    dateExpiration = dateExp_box.Value,
                    FournisseurId =fournisseurId


            });

            }
            SetUpTable();
            CleanTheBoxes();

        }

        private void AddAchat()
        {
            foreach (var item in _mesArticles)
            {
                _totalPayé += item.prixAchat * item.quantité;
            }
            var achat = new Achat { dateAchat = dateAchat_box.Value, montantTotal = _totalPayé };
            GestionnaireProInsertingMethods.AddAchat(achat);


            var achatId = GestionnaireProRetreivingMethods.RetreiveLastInsertedRowId("achats").Result;
            AddDetailsAchat(achatId);
        }
        private void AddDetailsAchat(int achatId)
        {
            var _mesArticleAchat = new List<DetailAchat>();
            foreach (var item in _mesArticles)
            {
                _mesArticleAchat.Add(new DetailAchat
                {
                    nom = item.nom,
                    codeBarre=item.codeBarre,
                    dateExpiration=item.dateExpiration,
                    prixAchat=item.prixAchat,
                    prixVente=item.prixVente,
                    Quantité = item.quantité,
                    Type=item.type,
                    fournisseurId=item.FournisseurId,
                    AchatId=achatId

                }) ;
            }
            GestionnaireProInsertingMethods.AddDetailAchat(_mesArticleAchat);
            MessageBox.Show("Opération Terminer Avec Succée");
           
        }
        private void sub_btn_Click(object sender, EventArgs e)
        {

            if(_mesArticles.Count < 1)
            {
                return;
            }
            
            AddAchat();

            _totalPayé = 0;
            CleanTheBoxes();
            _mesArticles = new List<Article>();
            SetUpTable();

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            var currentRowId =Convert.ToInt32( articleTable[1, articleTable.SelectedRows[0].Index].Value);
            var articleIndex = _mesArticles.FindIndex(a => a.Id == currentRowId);
            if (articleIndex != -1)
            {
                _mesArticles.RemoveAt(articleIndex);
                SetUpTable();
            }
            
        }

        private void qnt_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, qnt_txt);
            
        }

        private void prixA_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, prixA_txt);
        }

        private void prixV_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, prixV_txt);
        }
    }
}
