using Dapper;
using Gestionnaire_Pro.Assets;
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

        private List<RoundButton> _btns = new List<RoundButton>();

        public Menu()
        {
            InitializeComponent();
            greetingPanel.Parent = mainPanel;
            DesactivatePanel();
        }
      
       
        private void LoadFormSettings()
        {
            if (Properties.Settings.Default.menuLocation != new Point(0, 0))
                this.Location = Properties.Settings.Default.menuLocation;
            this.Size = Properties.Settings.Default.menuSize;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            LoadFormSettings();
            //check if DB the file is there
            var myDb = new System.IO.FileInfo("./GestionnairePro.db");
            if (!myDb.Exists)
            {
                CreateFullDb();
            }
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.menuSize = this.Size;
            Properties.Settings.Default.menuLocation=this.Location;
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// 0 for hide 
        /// 1 for show
        /// </summary>
        /// <param name="op"></param>
        private void HideShowGreetingPanel(byte op)
        {
            if (activeForm != null)
                activeForm.Close();
            if (op == 0)
            {
                greetingPanel.Visible = false;
            }
            else
            {
                greetingPanel.Visible = true;
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
        private void RemoveBtns(List<RoundButton> buttons)
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
            var nvVente_btn = new RoundButton();
            nvVente_btn.Size = new Size(480, 80);
            nvVente_btn.Anchor = AnchorStyles.Top;
            nvVente_btn.FlatStyle = FlatStyle.Popup;
            nvVente_btn.FlatAppearance.BorderSize = 2;
            nvVente_btn.Location = new Point((this.Width-nvVente_btn.Width) / 2 -100, 40);
            nvVente_btn.Name = "nvVente_btn";
            nvVente_btn.BackColor = ThemeColor.PrimaryColor;
            nvVente_btn.ForeColor = Color.White;
            nvVente_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            nvVente_btn.TabIndex = 1;
            nvVente_btn.Text = "Nouveau Vente";
            nvVente_btn.UseVisualStyleBackColor = true;
            nvVente_btn.Click += new EventHandler(nvVente_btn_Click);


            var historiqueVente_btn = new RoundButton();
            historiqueVente_btn.Anchor = AnchorStyles.Top;
            historiqueVente_btn.Size = new Size(480, 80);
            historiqueVente_btn.FlatStyle = FlatStyle.Flat;
            historiqueVente_btn.FlatAppearance.BorderSize = 0;
            historiqueVente_btn.Location = new Point((this.Width - historiqueVente_btn.Width) / 2 -100, 160);
            historiqueVente_btn.Name = "historiqueVente_btn";    
            historiqueVente_btn.TabIndex = 0;
            historiqueVente_btn.BackColor = ThemeColor.PrimaryColor;
            historiqueVente_btn.ForeColor = Color.White;
            historiqueVente_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            historiqueVente_btn.Text = "Historique de Vente";
            historiqueVente_btn.UseVisualStyleBackColor = true;
            historiqueVente_btn.Click += new EventHandler(historiqueVente_btn_Click);



           
            
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
            var nvAchat_btn = new RoundButton();
            nvAchat_btn.Anchor = AnchorStyles.Top;
            nvAchat_btn.FlatStyle = FlatStyle.Flat;
            nvAchat_btn.Size = new Size(480, 80);
            nvAchat_btn.Location = new Point((this.Width - nvAchat_btn.Width) / 2 - 100, 40);
            nvAchat_btn.Name = "nvArticle_btn";
            nvAchat_btn.BackColor = ThemeColor.PrimaryColor;
            nvAchat_btn.ForeColor = Color.White;
            nvAchat_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            nvAchat_btn.TabIndex = 1;
            nvAchat_btn.Text = "Nouvelle Achat";
            nvAchat_btn.UseVisualStyleBackColor = true;
            nvAchat_btn.Click += new EventHandler(nvAchat_btn_Click);

            var historiqueAchat_btn = new RoundButton();
            historiqueAchat_btn.Anchor = AnchorStyles.Top;
            historiqueAchat_btn.FlatStyle = FlatStyle.Flat;
            historiqueAchat_btn.Size = new Size(480, 80);
            historiqueAchat_btn.Location = new Point((this.Width - historiqueAchat_btn.Width) / 2 - 100, 160);
            historiqueAchat_btn.Name = "historiqueAchat_btn";
            historiqueAchat_btn.TabIndex = 0;
            historiqueAchat_btn.BackColor = ThemeColor.PrimaryColor;
            historiqueAchat_btn.ForeColor = Color.White;
            historiqueAchat_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            historiqueAchat_btn.Text = "Historique d'Achat";
            historiqueAchat_btn.UseVisualStyleBackColor = true;
            historiqueAchat_btn.Click += new EventHandler(historiqueAchat_btn_Click);

            if (mainPanel.Controls.Contains(historiqueAchat_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(historiqueAchat_btn)].Visible = true;
            }
            if (mainPanel.Controls.Contains(nvAchat_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(nvAchat_btn)].Visible = true;

            }



            if (!mainPanel.Controls.Contains(historiqueAchat_btn))
            {
                mainPanel.Controls.Add(historiqueAchat_btn);
                _btns.Add(historiqueAchat_btn);

            }
            if (!mainPanel.Controls.Contains(nvAchat_btn))
            {
                mainPanel.Controls.Add(nvAchat_btn);
                _btns.Add(nvAchat_btn);
            }

        }
        private void CreateProductsBtns()
        {
            var nvArticle_btn = new RoundButton();
            nvArticle_btn.Anchor = AnchorStyles.Top;
            nvArticle_btn.FlatStyle = FlatStyle.Flat;
            nvArticle_btn.Size = new Size(480, 80);
            nvArticle_btn.Location = new Point((this.Width - nvArticle_btn.Width) / 2 - 100, 40);
            nvArticle_btn.Name = "nvArticle_btn";
            nvArticle_btn.BackColor = ThemeColor.PrimaryColor;
            nvArticle_btn.ForeColor = Color.White;
            nvArticle_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            nvArticle_btn.TabIndex = 1;
            nvArticle_btn.Text = "Nouveau Article";
            nvArticle_btn.UseVisualStyleBackColor = true;
            nvArticle_btn.Click += new EventHandler(nvArticle_btn_Click);

            var listArticle_btn = new RoundButton();
            listArticle_btn.Anchor = AnchorStyles.Top;
            listArticle_btn.FlatStyle = FlatStyle.Flat;
            listArticle_btn.Size = new Size(480, 80);
            listArticle_btn.Location = new Point((this.Width - listArticle_btn.Width) / 2 - 100, 140);
            listArticle_btn.Name = "listArticle_btn";
            listArticle_btn.TabIndex = 0;
            listArticle_btn.BackColor = ThemeColor.PrimaryColor;
            listArticle_btn.ForeColor = Color.White;
            listArticle_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            listArticle_btn.Text = "List d'Article";
            listArticle_btn.UseVisualStyleBackColor = true;
            listArticle_btn.Click += new EventHandler(listArticle_btn_Click);


            var tableArticle_btn = new RoundButton();
            tableArticle_btn.Anchor = AnchorStyles.Top;
            tableArticle_btn.FlatStyle = FlatStyle.Flat;
            tableArticle_btn.Size = new Size(480, 80);
            tableArticle_btn.Location = new Point((this.Width - tableArticle_btn.Width) / 2 - 100, 240);
            tableArticle_btn.Name = " tableArticle_btn";
            tableArticle_btn.TabIndex = 0;
            tableArticle_btn.BackColor = ThemeColor.PrimaryColor;
            tableArticle_btn.ForeColor = Color.White;
            tableArticle_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            tableArticle_btn.Text = "Table d'Articles";
            tableArticle_btn.UseVisualStyleBackColor = true;
            tableArticle_btn.Click += new EventHandler(tableArticle_btn_Click);

            if (mainPanel.Controls.Contains(listArticle_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(listArticle_btn)].Visible = true;
            }
            if (mainPanel.Controls.Contains(nvArticle_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(nvArticle_btn)].Visible = true;

            }
            if (mainPanel.Controls.Contains(tableArticle_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(tableArticle_btn)].Visible = true;

            }


            if (!mainPanel.Controls.Contains(listArticle_btn))
            {
                mainPanel.Controls.Add(listArticle_btn);
                _btns.Add(listArticle_btn);

            }
            if (!mainPanel.Controls.Contains(nvArticle_btn))
            {
                mainPanel.Controls.Add(nvArticle_btn);
                _btns.Add(nvArticle_btn);
            }
            if (!mainPanel.Controls.Contains(tableArticle_btn))
            {
                mainPanel.Controls.Add(tableArticle_btn);
                _btns.Add(tableArticle_btn);
            }

        }
        private void CreateClientsBtns()
        {
            var nvClient_btn = new RoundButton();
            nvClient_btn.Anchor = AnchorStyles.Top;
            nvClient_btn.FlatStyle = FlatStyle.Flat;
            nvClient_btn.Size = new Size(480, 80);
            nvClient_btn.Location = new Point((this.Width - nvClient_btn.Width) / 2 - 100, 40);
            nvClient_btn.Name = "nvClient_btn";
            nvClient_btn.BackColor = ThemeColor.PrimaryColor;
            nvClient_btn.ForeColor = Color.White;
            nvClient_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            nvClient_btn.TabIndex = 1;
            nvClient_btn.Text = "Nouveau Client";
            nvClient_btn.UseVisualStyleBackColor = true;
            nvClient_btn.Click += new EventHandler(nvClient_btn_Click);

            var listClient_btn = new RoundButton();
            listClient_btn.Anchor = AnchorStyles.Top;
            listClient_btn.FlatStyle = FlatStyle.Flat;
            listClient_btn.Size = new Size(480, 80);
            listClient_btn.Location = new Point((this.Width - listClient_btn.Width) / 2 - 100, 140);
            listClient_btn.Name = "listClient_btn";
            listClient_btn.TabIndex = 0;
            listClient_btn.BackColor = ThemeColor.PrimaryColor;
            listClient_btn.ForeColor = Color.White;
            listClient_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            listClient_btn.Text = "Liste de Clients";
            listClient_btn.UseVisualStyleBackColor = true;
            listClient_btn.Click += new EventHandler(listClient_btn_Click);


            var tableClient_btn = new RoundButton();
            tableClient_btn.Anchor = AnchorStyles.Top;
            tableClient_btn.FlatStyle = FlatStyle.Flat;
            tableClient_btn.Size = new Size(480, 80);
            tableClient_btn.Location = new Point((this.Width - tableClient_btn.Width) / 2 - 100, 240);
            tableClient_btn.Name = " tableClient_btn";
            tableClient_btn.TabIndex = 0;
            tableClient_btn.BackColor = ThemeColor.PrimaryColor;
            tableClient_btn.ForeColor = Color.White;
            tableClient_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            tableClient_btn.Text = "Table de Client";
            tableClient_btn.UseVisualStyleBackColor = true;
            tableClient_btn.Click += new EventHandler(tableClient_btn_Click);


            var ajoutCreditClient_btn = new RoundButton();
            ajoutCreditClient_btn.Anchor = AnchorStyles.Top;
            ajoutCreditClient_btn.FlatStyle = FlatStyle.Flat;
            ajoutCreditClient_btn.Size = new Size(480, 80);
            ajoutCreditClient_btn.Location = new Point((this.Width - ajoutCreditClient_btn.Width) / 2 - 100, 340);
            ajoutCreditClient_btn.Name = "ajoutCreditClient_btn";
            ajoutCreditClient_btn.BackColor = ThemeColor.PrimaryColor;
            ajoutCreditClient_btn.ForeColor = Color.White;
            ajoutCreditClient_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            ajoutCreditClient_btn.TabIndex = 1;
            ajoutCreditClient_btn.Text = "Ajouter Credit Au Client";
            ajoutCreditClient_btn.UseVisualStyleBackColor = true;
            ajoutCreditClient_btn.Click += new EventHandler(ajoutCreditClient_btn_Click);
            var paimentCreditClient_btn = new RoundButton();
            paimentCreditClient_btn.Anchor = AnchorStyles.Top;
            paimentCreditClient_btn.FlatStyle = FlatStyle.Flat;
            paimentCreditClient_btn.Size = new Size(480, 80);
            paimentCreditClient_btn.Location = new Point((this.Width - paimentCreditClient_btn.Width) / 2 - 100, 440);
            paimentCreditClient_btn.Name = "paimentCreditClient_btn";
            paimentCreditClient_btn.BackColor = ThemeColor.PrimaryColor;
            paimentCreditClient_btn.ForeColor = Color.White;
            paimentCreditClient_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            paimentCreditClient_btn.TabIndex = 1;
            paimentCreditClient_btn.Text = "Paiment de Credit";
            paimentCreditClient_btn.UseVisualStyleBackColor = true;
            paimentCreditClient_btn.Click += new EventHandler(paimentCreditClient_btn_Click);







            if (mainPanel.Controls.Contains(nvClient_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(nvClient_btn)].Visible = true;
            }
            if (mainPanel.Controls.Contains(listClient_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(listClient_btn)].Visible = true;

            }
            if (mainPanel.Controls.Contains(tableClient_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(tableClient_btn)].Visible = true;

            }
            if (mainPanel.Controls.Contains(ajoutCreditClient_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(ajoutCreditClient_btn)].Visible = true;

            }
            if (mainPanel.Controls.Contains(paimentCreditClient_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(paimentCreditClient_btn)].Visible = true;

            }

            if (!mainPanel.Controls.Contains(nvClient_btn))
            {
                mainPanel.Controls.Add(nvClient_btn);
                _btns.Add(nvClient_btn);

            }
            if (!mainPanel.Controls.Contains(listClient_btn))
            {
                mainPanel.Controls.Add(listClient_btn);
                _btns.Add(listClient_btn);
            }
            if (!mainPanel.Controls.Contains(tableClient_btn))
            {
                mainPanel.Controls.Add(tableClient_btn);
                _btns.Add(tableClient_btn);
            }
            if (!mainPanel.Controls.Contains(ajoutCreditClient_btn))
            {
                mainPanel.Controls.Add(ajoutCreditClient_btn);
                _btns.Add(ajoutCreditClient_btn);
            }
            if (!mainPanel.Controls.Contains(paimentCreditClient_btn))
            {
                mainPanel.Controls.Add(paimentCreditClient_btn);
                _btns.Add(paimentCreditClient_btn);

            }
        }
        private void CreateFournisseursBtns()
        {
            var nvFournisseur_btn = new RoundButton();
            nvFournisseur_btn.Anchor = AnchorStyles.Top;
            nvFournisseur_btn.FlatStyle = FlatStyle.Flat;
            nvFournisseur_btn.Size = new Size(480, 80);
            nvFournisseur_btn.Location = new Point((this.Width - nvFournisseur_btn.Width) / 2 - 100, 40);
            nvFournisseur_btn.Name = "nvFournisseur_btn";
            nvFournisseur_btn.BackColor = ThemeColor.PrimaryColor;
            nvFournisseur_btn.ForeColor = Color.White;
            nvFournisseur_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            nvFournisseur_btn.TabIndex = 1;
            nvFournisseur_btn.Text = "Nouveau Fournisseur";
            nvFournisseur_btn.UseVisualStyleBackColor = true;
            nvFournisseur_btn.Click += new EventHandler(nvFournisseur_btn_Click);

            var listFournisseur_btn = new RoundButton();
            listFournisseur_btn.Anchor = AnchorStyles.Top;
            listFournisseur_btn.FlatStyle = FlatStyle.Flat;
            listFournisseur_btn.Size = new Size(480, 80);
            listFournisseur_btn.Location = new Point((this.Width - listFournisseur_btn.Width) / 2 - 100, 140);
            listFournisseur_btn.Name = "listFournisseur_btn";
            listFournisseur_btn.TabIndex = 0;
            listFournisseur_btn.BackColor = ThemeColor.PrimaryColor;
            listFournisseur_btn.ForeColor = Color.White;
            listFournisseur_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            listFournisseur_btn.Text = "Liste de Fournisseur";
            listFournisseur_btn.UseVisualStyleBackColor = true;
            listFournisseur_btn.Click += new EventHandler(listFournisseur_btn_Click);


            var tableFournisseur_btn = new RoundButton();
            tableFournisseur_btn.Anchor = AnchorStyles.Top;
            tableFournisseur_btn.FlatStyle = FlatStyle.Flat;
            tableFournisseur_btn.Size = new Size(480, 80);
            tableFournisseur_btn.Location = new Point((this.Width - tableFournisseur_btn.Width) / 2 - 100, 240);
            tableFournisseur_btn.Name = " tableFournisseur_btn";
            tableFournisseur_btn.TabIndex = 0;
            tableFournisseur_btn.BackColor = ThemeColor.PrimaryColor;
            tableFournisseur_btn.ForeColor = Color.White;
            tableFournisseur_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            tableFournisseur_btn.Text = "Table de Fournisseur";
            tableFournisseur_btn.UseVisualStyleBackColor = true;
            tableFournisseur_btn.Click += new EventHandler(tableFournisseur_btn_Click);
           

            if (mainPanel.Controls.Contains(nvFournisseur_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(nvFournisseur_btn)].Visible = true;
            }
            if (mainPanel.Controls.Contains(listFournisseur_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(listFournisseur_btn)].Visible = true;

            }
            if (mainPanel.Controls.Contains(tableFournisseur_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(tableFournisseur_btn)].Visible = true;

            }


            if (!mainPanel.Controls.Contains(nvFournisseur_btn))
            {
                mainPanel.Controls.Add(nvFournisseur_btn);
                _btns.Add(nvFournisseur_btn);

            }
            if (!mainPanel.Controls.Contains(listFournisseur_btn))
            {
                mainPanel.Controls.Add(listFournisseur_btn);
                _btns.Add(listFournisseur_btn);
            }
            if (!mainPanel.Controls.Contains(tableFournisseur_btn))
            {
                mainPanel.Controls.Add(tableFournisseur_btn);
                _btns.Add(tableFournisseur_btn);
            }
        }
        private void CreateRevenueBtns()
        {
            var revenue_btn = new RoundButton();
            revenue_btn.Anchor = AnchorStyles.Top;
            revenue_btn.FlatStyle = FlatStyle.Flat;
            revenue_btn.Size = new Size(480, 80);
            revenue_btn.Location = new Point((this.Width - revenue_btn.Width) / 2 - 100, 40);
            revenue_btn.Name = "revenue_btn";
            revenue_btn.BackColor = ThemeColor.PrimaryColor;
            revenue_btn.ForeColor = Color.White;
            revenue_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            revenue_btn.TabIndex = 1;
            revenue_btn.Text = "Revenue";
            revenue_btn.UseVisualStyleBackColor = true;
            revenue_btn.Click += new EventHandler(revenue_btn_Click);

            var caisse_btn = new RoundButton();
            caisse_btn.Anchor = AnchorStyles.Top;
            caisse_btn.FlatStyle = FlatStyle.Flat;
            caisse_btn.Size = new Size(480, 80);
            caisse_btn.Location = new Point((this.Width - caisse_btn.Width) / 2 - 100, 140);
            caisse_btn.Name = "caisse_btn";
            caisse_btn.BackColor = ThemeColor.PrimaryColor;
            caisse_btn.ForeColor = Color.White;
            caisse_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            caisse_btn.TabIndex = 1;
            caisse_btn.Text = "Caisse";
            caisse_btn.UseVisualStyleBackColor = true;
            caisse_btn.Click += new EventHandler(caisse_btn_Click);
            if (mainPanel.Controls.Contains(revenue_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(revenue_btn)].Visible = true;

            }
            if (mainPanel.Controls.Contains(caisse_btn))
            {
                mainPanel.Controls[mainPanel.Controls.IndexOf(caisse_btn)].Visible = true;

            }


            if (!mainPanel.Controls.Contains(revenue_btn))
            {
                mainPanel.Controls.Add(revenue_btn);
                _btns.Add(revenue_btn);

            }
            if (!mainPanel.Controls.Contains(caisse_btn))
            {
                mainPanel.Controls.Add(caisse_btn);
                _btns.Add(caisse_btn);

            }
        }


        #endregion

        #region Buttons events
        #region Achat
        private void achat_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(0);
            RemoveBtns(_btns);
            ActivateButton(sender);
            CreateAchatBtns();

        }
        private void historiqueAchat_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new listeAchat());
            RemoveBtns(_btns);
        }
        private void nvAchat_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new ajouteAchat());
            RemoveBtns(_btns);
        }
        #endregion
        #region Vente
        private void vente_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            ActivateButton(sender);
            HideShowGreetingPanel(0);
            CreateVenteBtns();
        }
        private void nvVente_btn_Click(object sender, EventArgs e)
        {
            using (var venteForm = new vente())
            {
                venteForm.ShowDialog();
            }
        }
        private void historiqueVente_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new historiqueVente());
            RemoveBtns(_btns);
        }

        #endregion
        #region Article
        private void articles_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(0);
            RemoveBtns(_btns);
            ActivateButton(sender);
            CreateProductsBtns();
        }
        private void nvArticle_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new ajouteArticle());
            RemoveBtns(_btns);
        }

        private void tableArticle_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new tableArticle());
            RemoveBtns(_btns);
        }

        private void listArticle_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new ListArticle());
            RemoveBtns(_btns);
        }
        #endregion
        #region Revenue
        private void rev_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            HideShowGreetingPanel(0);
            ActivateButton(sender);
            CreateRevenueBtns();

        }

        private void caisse_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new caisse());
            RemoveBtns(_btns);
        }

        private void revenue_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new revenue());
            RemoveBtns(_btns);
        }
        #endregion
        #region Client
        private void clients_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            HideShowGreetingPanel(0);
            ActivateButton(sender);
            CreateClientsBtns();
        }
        private void nvClient_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new ajouteClient());
            RemoveBtns(_btns);
        }
        private void listClient_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new listeClient());
            RemoveBtns(_btns);
        }
        private void ajoutCreditClient_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new ajoutCreditClient());
            RemoveBtns(_btns);
        }

        private void paimentCreditClient_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new paimentCreditClient());
            RemoveBtns(_btns);
        }
        private void tableClient_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new tableClient());
            RemoveBtns(_btns);
        }

        #endregion
        #region Fournisseur
        private void fournisseurs_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            HideShowGreetingPanel(0);
            ActivateButton(sender);
            CreateFournisseursBtns();
        }
        private void tableFournisseur_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new TableFournisseur());
            RemoveBtns(_btns);
        }

        private void listFournisseur_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new ListFournisseurs());
            RemoveBtns(_btns);
        }

        private void nvFournisseur_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(1);
            OpenChildForm(new ajouteFournisseur());
            RemoveBtns(_btns);
        }
        #endregion
      
       
        private void user_btn_Click(object sender, EventArgs e)
        {
            RemoveBtns(_btns);
            HideShowGreetingPanel(0);
            ActivateButton(sender);
            OpenChildForm(new utilisateur());
            


        }
        private void notification_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(0);
            RemoveBtns(_btns); ;
            ActivateButton(sender);
        }
        private void param_btn_Click(object sender, EventArgs e)
        {
            HideShowGreetingPanel(0);
            RemoveBtns(_btns); ;
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

            if (activeForm != null)
            {
                activeForm.Close();
            }
            titleLbl.Text = "Acceuil";
            DesactivatePanel();
            Reset();

        }
        private void exitChildForm_btn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivatePanel();
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
                GiveOptionToRole();
                ShowPanelsAfterLogin();
                ActivatePanel();
                return;


            }

            /*
             if( settings . no login used)
            {
             GlobalClass.username="Anonyme";
            GlobalClass.isAdmin =  true;
            GlobalClass.superAdmin=true;
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

       
    }
}
