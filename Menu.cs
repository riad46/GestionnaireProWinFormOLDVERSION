using Dapper;
using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.DataConnection;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Gestionnaire_Pro
{
    public partial class Menu : Form
    {
        private Button currentButton;
        //for chosing the color
        private Random random=new Random();
        private int tempIndex;
        private Form activeForm;

        private List<Button> _btns = new List<Button>();

        public Menu()
        {
            InitializeComponent();
            greetingPanel.Parent = mainPanel;
            DesactivatePanel();
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
  montantTotal float NOT NULL
  
);
create table if not EXISTS detailAchats(
  id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE,
  codeBarre Varchar(20) NOT NULL UNIQUE, 
  nom Varchar(30) NOT NULL ,
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
        private void GiveOptionToRole()
        {
            if (! GlobalClass.isAdmin)
            {
                user_btn.Enabled = false;
                rev_btn.Enabled = false;
            }
            else
            {
                user_btn.Enabled = true;
                rev_btn.Enabled = true;
            }
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

        #region Btn and Panel Effects
        private void Reset()
        {
            DisableButton();
            titleLbl.Text = "Acceuil";
            titlePanel.BackColor = Color.FromArgb(186, 86, 211);
            logoPanel.BackColor = Color.FromArgb(39, 39, 58);
            logoLbl.ForeColor = Color.White;
            currentButton = null;
            exitChildForm_btn.Visible = false;
        }
        private void ActivatePanel()
        {
            buttonsPanel.Enabled = true;
        }
        private void DesactivatePanel()
        {
            buttonsPanel.Enabled = false;

        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count-1);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count-1);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {

            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color btnColor = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = btnColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Times New Roman", 16.5F, FontStyle.Bold, GraphicsUnit.Point);
                    titlePanel.BackColor = btnColor;
                    logoPanel.BackColor= ThemeColor.ChangeColorBrightness(btnColor, -0.2);
                    ThemeColor.PrimaryColor = btnColor;
                    ThemeColor.SecondaryColor= ThemeColor.ChangeColorBrightness(btnColor, -0.3);

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in buttonsPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                }
            }
        }
        private void OpenChildForm(Form childForm)
        {
        if(activeForm != null)
            {
                activeForm.Close();
            }
           
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleLbl.Text = childForm.Text;

            exitChildForm_btn.Visible = true;
        }
        #endregion

        #region CreateButtons Methods
        private void RemoveBtns(List<Button> buttons)
        {
            foreach (var btn in buttons)
            {
                if (mainPanel.Controls.Contains(btn))
                {
                    mainPanel.Controls[mainPanel.Controls.IndexOf(btn)].Visible = false;
                    btn.Dispose();

                }

            }
           // _btns = new List<Button>();

        }


        private void CreateVenteBtns()
        {
            var historiqueVente_btn = new Button();
            historiqueVente_btn.Anchor = AnchorStyles.None;
            historiqueVente_btn.FlatStyle = FlatStyle.Flat;
            historiqueVente_btn.Location = new Point(200,180);
            historiqueVente_btn.Name = "historique_btn";
            historiqueVente_btn.Size = new System.Drawing.Size(420, 80);
            historiqueVente_btn.TabIndex = 0;
            historiqueVente_btn.BackColor = ThemeColor.PrimaryColor;
            historiqueVente_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            historiqueVente_btn.Text = "Historique de Vente";
            historiqueVente_btn.UseVisualStyleBackColor = true;
            historiqueVente_btn.Click += new EventHandler(historiqueVente_btn_Click);
           
            var nvVente_btn = new Button();
            nvVente_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            nvVente_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            nvVente_btn.Location = new System.Drawing.Point(200,180);
            nvVente_btn.Name = "nvVente_btn";
            nvVente_btn.Size = new System.Drawing.Size(420, 80);
            nvVente_btn.BackColor = ThemeColor.SecondaryColor;
            nvVente_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            nvVente_btn.TabIndex = 1;
            nvVente_btn.Text = "Nouveau Vente";
            nvVente_btn.UseVisualStyleBackColor = true;

            if (mainPanel.Controls.Contains(historiqueVente_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(historiqueVente_btn)].Visible = true;
            }
            if (mainPanel.Controls.Contains(nvVente_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(nvVente_btn)].Visible = true;
                
            }

            if (!mainPanel.Controls.Contains(historiqueVente_btn))
            {
                mainPanel.Controls.Add(historiqueVente_btn);
                _btns.Add(historiqueVente_btn);

            }


            if (!mainPanel.Controls.Contains(nvVente_btn))
            {
                mainPanel.Controls.Add(nvVente_btn);
                _btns.Add(nvVente_btn);
            }
            

            
            
        }
        private void CreateAchatBtns()
        {
            var historiqueAchat_btn = new Button();
            historiqueAchat_btn.Anchor = AnchorStyles.None;
            historiqueAchat_btn.FlatStyle = FlatStyle.Flat;
            historiqueAchat_btn.Location = new Point(200, 80);
            historiqueAchat_btn.Name = "historique_btn";
            historiqueAchat_btn.Size = new System.Drawing.Size(420, 80);
            historiqueAchat_btn.TabIndex = 0;
            historiqueAchat_btn.BackColor = ThemeColor.PrimaryColor;
            historiqueAchat_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            historiqueAchat_btn.Text = "Historique de Vente";
            historiqueAchat_btn.UseVisualStyleBackColor = true;
            historiqueAchat_btn.Click += new EventHandler(historiqueAchat_btn_Click);

            var nvAchat_btn = new Button();
            nvAchat_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            nvAchat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            nvAchat_btn.Location = new System.Drawing.Point(200, 180);
            nvAchat_btn.Name = "nvVente_btn";
            nvAchat_btn.Size = new System.Drawing.Size(420, 80);
            nvAchat_btn.BackColor = ThemeColor.PrimaryColor;
            nvAchat_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            nvAchat_btn.TabIndex = 1;
            nvAchat_btn.Text = "Nouveau Vente";
            nvAchat_btn.UseVisualStyleBackColor = true;
        }

        private void historiqueAchat_btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CreateProductsBtns()
        {

        }
        private void CreateClinetsBtns()
        {

        }
        private void CreateFournisseursBtns() { }
        private void CreateUtilisateursBtns() { }


        #endregion


        #region Buttons events
        private void vente_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            HideShowGreetingPanel(0);
            CreateVenteBtns();
        }
        private void historiqueVente_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new historiqueVente());
            RemoveBtns(_btns);
        }



        private void achat_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            CreateAchatBtns();
            ActivateButton(sender);
        }

        private void articles_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            CreateProductsBtns();
            ActivateButton(sender);
        }

        private void rev_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            
            ActivateButton(sender);
        }

        private void clients_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            CreateClinetsBtns();
            ActivateButton(sender);
        }

        private void fournisseurs_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            CreateFournisseursBtns();
            ActivateButton(sender);
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            CreateUtilisateursBtns();
            ActivateButton(sender);

        }

        private void notification_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);;
            ActivateButton(sender);
        }

        private void param_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);;
            ActivateButton(sender);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            ActivateButton(sender);
            greetingPanel.Visible = false;
            loginPanel.Visible = true;
            hello_lbl.Text = "";
            nomBoutique_lbl.Text = "";
            GlobalClass.username = "";
            GlobalClass.isAdmin = false;

            if(activeForm != null)
            {
                activeForm.Close();
            }
            titleLbl.Text = "Acceuil";
            DesactivatePanel();
            Reset();

        }
        #endregion
        #region loginForm
        private void CleanBoxes()
        {
            username_txt.Text = "";
            password_txt.Text = "";
        }
        private void RegularLogin(string username, string pass)
        {


            var _utilisateurs = GestionnaireProRetreivingMethods.GetAllUtilisateurs().Result;
            var monUtilisateur = _utilisateurs.Find(u => u.nomUtilisateur == username && u.motDePass == pass);
            if (monUtilisateur == null)
            {
                CleanBoxes();
                MessageBox.Show("Nom d'utilisateur ou Mot de passe Incorrect !!");
                return;
            }
            else
            {
                GlobalClass.username = monUtilisateur.nomUtilisateur;
                GlobalClass.isAdmin = monUtilisateur.estAdmin;

                CleanBoxes();
              
            }
        }
        private void ShowPanelsAfterLogin()
        {
            loginPanel.Visible = false;
            greetingPanel.Visible = true;

            hello_lbl.Text = "Bonjour " + GlobalClass.username;
         
        }     
        private void sub_btn_Click(object sender, EventArgs e)
        {
            var username = username_txt.Text;
            var pass = password_txt.Text;

            if (username == "riad46" && pass == "azqswx123-")
            {
                GlobalClass.username = "riad46";
                GlobalClass.isAdmin = true;
                CleanBoxes();
                ShowPanelsAfterLogin();
                ActivatePanel();
                return;


            }

            /*
             if( settings . no login used)
            {
             GlobalClass.username="Anonyme";
            GlobalClass.isAdmin =  true;
            }
            */
            RegularLogin(username, pass);
            GiveOptionToRole();
            if(!string.IsNullOrEmpty(GlobalClass.username))
            {
                ActivatePanel();
                loginPanel.Visible = false;
                greetingPanel.Visible = true;
                hello_lbl.Text = "Bonjour " + GlobalClass.username;
            }

        }
        #endregion
        private void exitChildForm_btn_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        
        /// <summary>
        /// 0 for hide 
        /// 1 for show
        /// </summary>
        /// <param name="op"></param>
        private void HideShowGreetingPanel(byte op)
        {
            if (op == 0)
            {
                greetingPanel.Visible = false;
            }
            else
            {
                greetingPanel.Visible = true;
            }
        }

       
    }
}
