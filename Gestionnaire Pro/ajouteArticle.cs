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
        private int _id;
        
        public ajouteArticle()
        {
            InitializeComponent();
        }
        
        public ajouteArticle(Article article)
        {
            InitializeComponent();
            _id = article.Id;
            mesFournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs();
            codeBarre_txt.Text = article.codeBarre;
            nom_txt.Text = article.nom;
            qnt_txt.Text =  article.quantité.ToString();
            type_txt.Text = article.type;
            prixAchat_txt.Text = article.prixAchat.ToString();
            prixVente_txt.Text = article.prixVente.ToString();
            dateExp_txt.Text = article.dateExpiration.ToString();
            if(article.FournisseurId !=null)
            Fournisseur_combo.Text = mesFournisseurs.Find(f=>f.Id==article.FournisseurId).nom;
           

        }

       
        private void CleanTheFormBoxes()
        {
            codeBarre_txt.Text = "";
            nom_txt.Text = "";
            qnt_txt.Text = "";
            prixAchat_txt.Text = "";
            prixVente_txt.Text = "";
            dateExp_txt.Text = "";
            Fournisseur_combo.Text = "";
           
        }

        private void AddNewArticle()
        {
            var myArticle = new Article
            {
                codeBarre = codeBarre_txt.Text,
                nom = nom_txt.Text,
                type = type_txt.Text,
                quantité = Convert.ToSingle(Regex.Replace(qnt_txt.Text, @"\.", ",")),
                prixAchat = Convert.ToSingle(Regex.Replace(prixAchat_txt.Text, @"\.", ",")),
                prixVente = Convert.ToSingle(Regex.Replace(prixVente_txt.Text, @"\.", ","))
                

            };
            

            if (dateExp_txt.Text == "  /  /") 
            {
                myArticle.dateExpiration = null;
            }
            else
            {
                myArticle.dateExpiration = Convert.ToDateTime(dateExp_txt.Text);
            }              
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
           
            if (dateExp_txt.Text.Trim()!="/  /")
            {
                myArticle.dateExpiration = Convert.ToDateTime(dateExp_txt.Text);
            }
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
        }

        private void ajouteArticle_Load(object sender, EventArgs e)
        {
            mesFournisseurs = GestionnaireProRetreivingMethods.GetAllFournisseurs();
            foreach (var fournisseur in mesFournisseurs)
            {
                Fournisseur_combo.Items.Add(fournisseur.nom);
            }
        }

      
      
        
    }
}
