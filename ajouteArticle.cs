using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class ajouteArticle : Form
    {
        private List<Fournisseur> mesFournisseurs = new List<Fournisseur>();
        private List<Article> _mesArticles = new List<Article>();
        private int _id;
        
        public ajouteArticle()
        {
            InitializeComponent();
            LoadTheme();
            GetMyArticles();
            if (Properties.Settings.Default.autoCodeBarre)
            {
                codeBarre_txt.Enabled = false;
                AutoGenerateCodeBarre();
            }
        }
        public ajouteArticle(Article article)
        {

            
            InitializeComponent();
            GetMyArticles();
          

            _id = article.Id;
            mesFournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs().Result;
            codeBarre_txt.Text = article.codeBarre;
            nom_txt.Text = article.nom;
            qnt_txt.Text = article.quantité.ToString();
            type_txt.Text = article.type;
            prixAchat_txt.Text = article.prixAchat.ToString();
            prixVente_txt.Text = article.prixVente.ToString();
            dateExp.Value = article.dateExpiration.Value;
            if (article.FournisseurId != null)
                Fournisseur_combo.Text = mesFournisseurs.Find(f => f.Id == article.FournisseurId).nom;


        }

        private void LoadTheme()
        {
            foreach (var item in Controls)
            {
                if (item.GetType() == new Button().GetType())
                {
                    ((Button)item).BackColor = ThemeColor.PrimaryColor;
                    ((Button)item).ForeColor = Color.White;
                }
            }
        }
        
        private void GetMyArticles()
        {
            _mesArticles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
        }
        private void AutoGenerateCodeBarre()
        {
            Random r = new Random();
            var codeBarre=r.Next(1111111, 12345678);
            while(_mesArticles.FindIndex(a=>a.codeBarre==codeBarre.ToString()) != -1)
            {
                codeBarre = r.Next(1111111, 12345678);
            }
            codeBarre_txt.Text = codeBarre.ToString();

        }
      
        private void CleanTheFormBoxes()
        {
            codeBarre_txt.Text = "";
            nom_txt.Text = "";
            qnt_txt.Text = "";
            prixAchat_txt.Text = "";
            prixVente_txt.Text = "";
           dateExp.Value = DateTime.Now;
            Fournisseur_combo.Text = "";
           
        }

        private void AddNewArticle()
        {
            // CheckArticleAvalability();
            if (_mesArticles.FindIndex(a => a.codeBarre == codeBarre_txt.Text || a.nom == nom_txt.Text) != -1)
            {
                MessageBox.Show("Article Existe Déja !!");
                return;
            }
            var myArticle = new Article
            {
                codeBarre = codeBarre_txt.Text,
                nom = nom_txt.Text,
                type = type_txt.Text,
                quantité = Convert.ToSingle(Regex.Replace(qnt_txt.Text, @"\.", ",")),
                prixAchat = Convert.ToSingle(Regex.Replace(prixAchat_txt.Text, @"\.", ",")),
                prixVente = Convert.ToSingle(Regex.Replace(prixVente_txt.Text, @"\.", ","))
                

            };
            

           
              
            myArticle.dateExpiration = dateExp.Value;
                     
                if (Fournisseur_combo.Text != "")
            {
                myArticle.FournisseurId = GestionnaireProRetreivingMethods.GetFournisseurIdByNom(Fournisseur_combo.Text);
            }
            GestionnaireProInsertingMethods.AddArticle(myArticle);
            MessageBox.Show("L'article a été Ajouté avec Succée");
        }
        private void ModifyArticle()
        {
            var myArticle = new Article
            {
                Id = _id,
                codeBarre = codeBarre_txt.Text,
                nom = nom_txt.Text,
                type = type_txt.Text,
                quantité = Convert.ToSingle(Regex.Replace(qnt_txt.Text, @"\.", ",")),
                prixAchat = Convert.ToSingle(Regex.Replace(prixAchat_txt.Text, @"\.", ",")),
                prixVente = Convert.ToSingle(Regex.Replace(prixVente_txt.Text, @"\.", ","))


            };
           
          
                myArticle.dateExpiration = dateExp.Value;
            
            if (Fournisseur_combo.Text != "")
            {
                myArticle.FournisseurId = GestionnaireProRetreivingMethods.GetFournisseurIdByNom(Fournisseur_combo.Text);
            }
            else
            {
                myArticle.FournisseurId = null;
            }
            GestionnaireProModifyDeleteMethods.ModifyArticle(myArticle);
            MessageBox.Show("L'article a été Modifier avec Succée");
            this.Close();
        }
       
        private void ActionToDo()
        {
            switch (GlobalClass.typeOp)
            {
                case 0:
                    AddNewArticle();
                    break;
                case 1:
                    ModifyArticle();
                    break;
                
                default:
                    break;
            }


        }


        private void sub_btn_Click(object sender, EventArgs e)
        {
           
            ActionToDo();      
            CleanTheFormBoxes();
            GetMyArticles();
            if (Properties.Settings.Default.autoCodeBarre)
            {
                codeBarre_txt.Enabled = false;
                AutoGenerateCodeBarre();
            }
          
        }

        private void ajouteArticle_Load(object sender, EventArgs e)
        {
            mesFournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs().Result;
            foreach (var fournisseur in mesFournisseurs)
            {
                Fournisseur_combo.Items.Add(fournisseur.nom);
            }
        }

        private void qnt_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, qnt_txt);
        }

        private void prixAchat_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e,prixAchat_txt);
        }

        private void prixVente_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e,prixVente_txt);
        }
    }
}
