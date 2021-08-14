using Dapper;
using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.DataConnection;
using Microsoft.Data.Sqlite;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



      

      

       
        private void Menu_Load(object sender, EventArgs e)
        {
            //check if the file is there
            var myDb = new System.IO.FileInfo("./GestionnairePro.db");
            if (!myDb.Exists)
            {
                CreateFullDb();
            }
            
        }
       
        private void CreateFullDb()
        {
            
            var c = File.Create(@".\GestionnairePro.db");
            c.Close();
            var sql = @"CREATE TABLE IF NOT EXISTS utilisateurs(
 id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  nomUtilisateur varchar(20) UNIQUE,
  motDePass varchar(50) ,
  numTlf varchar(14),
  estAdmin bool 
);
CREATE TABLE if not EXISTS infosBoutique(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  nomBoutique varchar(20) UNIQUE,
  address varchar(50) ,
  numTlf varchar(14),
  logo blob 
);
create TABLE if not EXISTS clients( 
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  nom varchar(20) NOT NULL unique ,
  address VARCHAR(50),
  numTlf varchar(14),
  credit float
  
);
create TABLE if not EXISTS fournisseurs(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  nom varchar(20) NOT NULL unique,
  address VARCHAR(50),
  numTlf varchar(15),
  creditArendre float
);

create table if not EXISTS articles(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  codeBarre Varchar(20) NOT NULL UNIQUE, 
  nom Varchar(30) NOT NULL UNIQUE,
  Type Varchar(20) ,
  Quantité float NOT NULL ,
  prixAchat FLoat NOT NULL,
  prixVente float NOT NULL,
  dateExpiration date ,
  fournisseurId int ,
  FOREIGN KEY(fournisseurId) REFERENCES fournisseurs(id)
);
create table if not exists ventes(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  dateVente datetime not null unique,
  montantTotale float not null,
  remise float not null,
  netPayé float NOT NULL,
  ajouterPar varchar(20) NOT NULL,
  dateModification datetime ,
  modifierPar varchar(20),
  nouveauMontantTotal float,
  nouvelleRemise float ,
  clientId int ,
  FOREIGN KEY(clientId) REFERENCES clients(id)
  ON DELETE CASCADE ON UPDATE CASCADE
);
create table if not EXISTS detailVentes(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  codeBarre Varchar(20) NOT NULL , 
  nom Varchar(30) NOT NULL ,
  Type Varchar(20) ,
  Quantité float NOT NULL ,
  prixAchat FLoat not null,
  prixVente float NOT NULL,
  remise float not NULL,
  nouvelleQuantité float,
  nouvelleRemise float,
  nouveauTotale float,
  venteId int NOT NULL,
  FOREIGN key(venteId) REFERENCES ventes(id) 
  ON DELETE CASCADE ON UPDATE CASCADE
);
create table if not EXISTS achats(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  dateAchat date not null,
  montantTotale float NOT NULL
  
);
create table if not EXISTS detailAchats(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  codeBarre Varchar(20) NOT NULL UNIQUE, 
  nom Varchar(30) NOT NULL UNIQUE,
  Type Varchar(20) ,
  Quantité float NOT NULL ,
  prixAchat FLoat NOT NULL,
  prixVente float NOT NULL,
  dateExpiration date ,
  achatId int NOT NULL,
  fournisseurId int ,
  FOREIGN KEY(fournisseurId) REFERENCES fournisseurs(id),
  FOREIGN KEY(achatId) REFERENCES achats(id) 
  ON DELETE CASCADE ON UPDATE CASCADE
);
create table if not EXISTS detailCreditClients(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  descriptionProduit varchar(50) NOT NULL,
  dateCredit DATETIME NOT NULL,
  prixTotale float,
  restApayé float,
  estPayé bool,
  clientId int NOT NULL,
  FOREIGN KEY(clientId) REFERENCES clients(id)
   ON DELETE CASCADE ON UPDATE CASCADE
);
create table if not EXISTS actionsEffectué(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  descriptionAction varchar(50) NOT NULL,
  utilisateur varchar(20) not null,
  dateAction datetime NOT NULL
 
);
create table if not EXISTS ProduitExcluDeVerification(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  articleId int NOT NULL,
  FOREIGN KEY(articleId) REFERENCES articles(id)
   ON DELETE CASCADE ON UPDATE CASCADE
);";
            using (var connection = new SqliteConnection(GestionnaireProConnection.GetConnectionString("SQLiteConnection")))
            {
               
                connection.Execute(sql);
            }
        }

     

        private void nvVenteDropItem_Click_1(object sender, EventArgs e)
        {
            using(var  v = new vente())
            {
                v.ShowDialog();
            }
        }

        private void addArticleDropItem_Click_1(object sender, EventArgs e)
        {
            using (var addArticle= new ajouteArticle())
            {
                addArticle.ShowDialog();
            }
        }

       
       

        private void listeDArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var listArticle = new ListArticle())
            {
                listArticle.ShowDialog();
            }
        }

        private void addClientDropItem_Click_1(object sender, EventArgs e)
        {
            using (var c = new ajouteClient())
            {
                c.ShowDialog();
            }
        }

        private void listClientsDropItem_Click_1(object sender, EventArgs e)
        {
            using (var c = new listeClient())
            {
                c.ShowDialog();
            }
        }

        private void tableDeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var c = new tableClient())
            {
                c.ShowDialog();
            }
        }
        private void ajouterCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var c = new ajoutCredit())
            {
                c.ShowDialog();
            }
        }
        private void addFournisseurDropItem_Click_1(object sender, EventArgs e)
        {
            using (var f = new ajouteFournisseur())
            {
                f.ShowDialog();
            }
        }

        private void listFournisseurDropItem_Click_1(object sender, EventArgs e)
        {
            using (var listF = new ListFournisseurs())
            {
                listF.ShowDialog();
            }
        }

        private void paimentDeCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var p = new paimentCreditClient())
            {
                p.ShowDialog();
            }
        }

        private void infoBoutiqueDropList_Click_1(object sender, EventArgs e)
        {
          //  if (GlobalClass.isAdmin != true) return;
            using(var infoWin =new infosBoutique())
            {
                infoWin.ShowDialog();
            }
        }

        private void tableDArticlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (tableArticle tableArticleForm = new tableArticle())
            {
                tableArticleForm.ShowDialog();
            }
        }

        private void tableDArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        using(var AjoutAForm =new ajouteArticle())
            {
                AjoutAForm.ShowDialog();
            }    
        }

        private void caisseDropItem_Click_1(object sender, EventArgs e)
        {
            using (var caisseForm = new caisse())
            {
                caisseForm.ShowDialog();
            }
        }

        private void utilisateurDropItem_Click_1(object sender, EventArgs e)
        {
            using (var userForm = new utilisateur())
            {
                userForm.ShowDialog();
            }
        }

        private void revenueDropItem_Click_1(object sender, EventArgs e)
        {
            using (var revForm = new revenue())
            {
                revForm.ShowDialog();
            }
        }

        private void parametreDropItem_Click_1(object sender, EventArgs e)
        {
            using (var paramForm = new param())
            {
                paramForm.ShowDialog();
            }
        }

        private void tableFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TableFournisseur())
            {
                f.ShowDialog();
            }
        }

        private void nvAchatDropItem_Click_1(object sender, EventArgs e)
        {
            using (var AjoutAchatForm = new ajouteAchat())
            {
                AjoutAchatForm.ShowDialog();
            }
        }

        private void listAchatDropItem_Click_1(object sender, EventArgs e)
        {
            using( var listAchatForm =new listeAchat())
            {
                listAchatForm.ShowDialog();
            }
        }

        private void tableDAchatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tableAchat= new TableAchat())
            {
                tableAchat.ShowDialog();

            }
        }

        private void historyVenteDropItem_Click_1(object sender, EventArgs e)
        {
            using(var historiqueVente =new historiqueVente())
            {
                historiqueVente.ShowDialog();
            }
        }

        private void nvVente_pic_Click(object sender, EventArgs e)
        {
            using (var v = new vente())
            {
                v.ShowDialog();
            }
        }

        private void historiqueVente_pic_Click(object sender, EventArgs e)
        {
            using (var historiqueVente = new historiqueVente())
            {
                historiqueVente.ShowDialog();
            }
        }

        private void articlesList_pic_Click(object sender, EventArgs e)
        {
            using (var listArticle = new ListArticle())
            {
                listArticle.ShowDialog();
            }
        }

        private void venteLabel_Click(object sender, EventArgs e)
        {
            using (var v = new vente())
            {
                v.ShowDialog();
            }
        }

        private void historiqueVenteLabel_Click(object sender, EventArgs e)
        {
            using (var historiqueVente = new historiqueVente())
            {
                historiqueVente.ShowDialog();
            }
        }

        private void listArticlesLabel_Click(object sender, EventArgs e)
        {
            using (var listArticle = new ListArticle())
            {
                listArticle.ShowDialog();
            }
        }

      
    }
}
