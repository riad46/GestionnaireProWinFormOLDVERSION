
using System;

namespace Gestionnaire_Pro
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.actions_btn = new System.Windows.Forms.Button();
            this.notification_btn = new System.Windows.Forms.Button();
            this.user_btn = new System.Windows.Forms.Button();
            this.fournisseurs_btn = new System.Windows.Forms.Button();
            this.clients_btn = new System.Windows.Forms.Button();
            this.rev_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.articles_btn = new System.Windows.Forms.Button();
            this.achat_btn = new System.Windows.Forms.Button();
            this.vente_btn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoLbl = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.exitChildForm_btn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.sub_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.greetingPanel = new System.Windows.Forms.Panel();
            this.hello_lbl = new System.Windows.Forms.Label();
            this.nomBoutique_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.greetingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonsPanel.Controls.Add(this.actions_btn);
            this.buttonsPanel.Controls.Add(this.notification_btn);
            this.buttonsPanel.Controls.Add(this.user_btn);
            this.buttonsPanel.Controls.Add(this.fournisseurs_btn);
            this.buttonsPanel.Controls.Add(this.clients_btn);
            this.buttonsPanel.Controls.Add(this.rev_btn);
            this.buttonsPanel.Controls.Add(this.exit_btn);
            this.buttonsPanel.Controls.Add(this.articles_btn);
            this.buttonsPanel.Controls.Add(this.achat_btn);
            this.buttonsPanel.Controls.Add(this.vente_btn);
            this.buttonsPanel.Controls.Add(this.logoPanel);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(229, 581);
            this.buttonsPanel.TabIndex = 0;
            // 
            // actions_btn
            // 
            this.actions_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actions_btn.FlatAppearance.BorderSize = 0;
            this.actions_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actions_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.actions_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.actions_btn.Image = global::Gestionnaire_Pro.Properties.Resources.rinse__1_;
            this.actions_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actions_btn.Location = new System.Drawing.Point(0, 471);
            this.actions_btn.Name = "actions_btn";
            this.actions_btn.Size = new System.Drawing.Size(229, 50);
            this.actions_btn.TabIndex = 18;
            this.actions_btn.Text = "Historique";
            this.actions_btn.UseVisualStyleBackColor = true;
            this.actions_btn.Click += new System.EventHandler(this.param_btn_Click);
            // 
            // notification_btn
            // 
            this.notification_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.notification_btn.FlatAppearance.BorderSize = 0;
            this.notification_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notification_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notification_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.notification_btn.Image = global::Gestionnaire_Pro.Properties.Resources.notification__1_;
            this.notification_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notification_btn.Location = new System.Drawing.Point(0, 422);
            this.notification_btn.Name = "notification_btn";
            this.notification_btn.Size = new System.Drawing.Size(229, 50);
            this.notification_btn.TabIndex = 17;
            this.notification_btn.Text = "Notifications";
            this.notification_btn.UseVisualStyleBackColor = true;
            this.notification_btn.Visible = false;
            this.notification_btn.Click += new System.EventHandler(this.notification_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_btn.FlatAppearance.BorderSize = 0;
            this.user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.user_btn.Image = global::Gestionnaire_Pro.Properties.Resources.login__1_;
            this.user_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_btn.Location = new System.Drawing.Point(0, 372);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(229, 50);
            this.user_btn.TabIndex = 16;
            this.user_btn.Text = "Utilisateurs";
            this.user_btn.UseVisualStyleBackColor = true;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // fournisseurs_btn
            // 
            this.fournisseurs_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.fournisseurs_btn.FlatAppearance.BorderSize = 0;
            this.fournisseurs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fournisseurs_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fournisseurs_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.fournisseurs_btn.Image = global::Gestionnaire_Pro.Properties.Resources.salesman__1_;
            this.fournisseurs_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fournisseurs_btn.Location = new System.Drawing.Point(0, 322);
            this.fournisseurs_btn.Name = "fournisseurs_btn";
            this.fournisseurs_btn.Size = new System.Drawing.Size(229, 50);
            this.fournisseurs_btn.TabIndex = 15;
            this.fournisseurs_btn.Text = "Fournisseurs";
            this.fournisseurs_btn.UseVisualStyleBackColor = true;
            this.fournisseurs_btn.Click += new System.EventHandler(this.fournisseurs_btn_Click);
            // 
            // clients_btn
            // 
            this.clients_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clients_btn.FlatAppearance.BorderSize = 0;
            this.clients_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clients_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clients_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.clients_btn.Image = global::Gestionnaire_Pro.Properties.Resources.profile__1_;
            this.clients_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clients_btn.Location = new System.Drawing.Point(0, 272);
            this.clients_btn.Name = "clients_btn";
            this.clients_btn.Size = new System.Drawing.Size(229, 50);
            this.clients_btn.TabIndex = 14;
            this.clients_btn.Text = "Clients";
            this.clients_btn.UseVisualStyleBackColor = true;
            this.clients_btn.Click += new System.EventHandler(this.clients_btn_Click);
            // 
            // rev_btn
            // 
            this.rev_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rev_btn.FlatAppearance.BorderSize = 0;
            this.rev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rev_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rev_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.rev_btn.Image = ((System.Drawing.Image)(resources.GetObject("rev_btn.Image")));
            this.rev_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rev_btn.Location = new System.Drawing.Point(0, 222);
            this.rev_btn.Name = "rev_btn";
            this.rev_btn.Size = new System.Drawing.Size(229, 50);
            this.rev_btn.TabIndex = 11;
            this.rev_btn.Text = "Statistique";
            this.rev_btn.UseVisualStyleBackColor = true;
            this.rev_btn.Click += new System.EventHandler(this.rev_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Location = new System.Drawing.Point(0, 521);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(229, 60);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Quitter";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // articles_btn
            // 
            this.articles_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.articles_btn.FlatAppearance.BorderSize = 0;
            this.articles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.articles_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.articles_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.articles_btn.Image = ((System.Drawing.Image)(resources.GetObject("articles_btn.Image")));
            this.articles_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.articles_btn.Location = new System.Drawing.Point(0, 172);
            this.articles_btn.Name = "articles_btn";
            this.articles_btn.Size = new System.Drawing.Size(229, 50);
            this.articles_btn.TabIndex = 4;
            this.articles_btn.Text = "Produits";
            this.articles_btn.UseVisualStyleBackColor = true;
            this.articles_btn.Click += new System.EventHandler(this.articles_btn_Click);
            // 
            // achat_btn
            // 
            this.achat_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.achat_btn.FlatAppearance.BorderSize = 0;
            this.achat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.achat_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.achat_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.achat_btn.Image = ((System.Drawing.Image)(resources.GetObject("achat_btn.Image")));
            this.achat_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.achat_btn.Location = new System.Drawing.Point(0, 122);
            this.achat_btn.Name = "achat_btn";
            this.achat_btn.Size = new System.Drawing.Size(229, 50);
            this.achat_btn.TabIndex = 3;
            this.achat_btn.Text = "Achat";
            this.achat_btn.UseVisualStyleBackColor = true;
            this.achat_btn.Click += new System.EventHandler(this.achat_btn_Click);
            // 
            // vente_btn
            // 
            this.vente_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vente_btn.FlatAppearance.BorderSize = 0;
            this.vente_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vente_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vente_btn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.vente_btn.Image = ((System.Drawing.Image)(resources.GetObject("vente_btn.Image")));
            this.vente_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vente_btn.Location = new System.Drawing.Point(0, 72);
            this.vente_btn.Name = "vente_btn";
            this.vente_btn.Size = new System.Drawing.Size(229, 50);
            this.vente_btn.TabIndex = 2;
            this.vente_btn.Text = "Vente";
            this.vente_btn.UseVisualStyleBackColor = true;
            this.vente_btn.Click += new System.EventHandler(this.vente_btn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoPanel.Controls.Add(this.logoLbl);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(229, 72);
            this.logoPanel.TabIndex = 0;
            // 
            // logoLbl
            // 
            this.logoLbl.AutoSize = true;
            this.logoLbl.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logoLbl.Location = new System.Drawing.Point(22, 19);
            this.logoLbl.Name = "logoLbl";
            this.logoLbl.Size = new System.Drawing.Size(177, 25);
            this.logoLbl.TabIndex = 2;
            this.logoLbl.Text = "Gestionnaire_Pro";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.MediumOrchid;
            this.titlePanel.Controls.Add(this.exitChildForm_btn);
            this.titlePanel.Controls.Add(this.titleLbl);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(229, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(717, 72);
            this.titlePanel.TabIndex = 1;
            // 
            // exitChildForm_btn
            // 
            this.exitChildForm_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitChildForm_btn.BackgroundImage")));
            this.exitChildForm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitChildForm_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.exitChildForm_btn.FlatAppearance.BorderSize = 0;
            this.exitChildForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitChildForm_btn.Location = new System.Drawing.Point(0, 0);
            this.exitChildForm_btn.Name = "exitChildForm_btn";
            this.exitChildForm_btn.Size = new System.Drawing.Size(53, 72);
            this.exitChildForm_btn.TabIndex = 1;
            this.exitChildForm_btn.UseVisualStyleBackColor = true;
            this.exitChildForm_btn.Visible = false;
            this.exitChildForm_btn.Click += new System.EventHandler(this.exitChildForm_btn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.titleLbl.Location = new System.Drawing.Point(178, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(377, 35);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Acceuil";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Controls.Add(this.loginPanel);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(229, 72);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(717, 509);
            this.mainPanel.TabIndex = 2;
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.Controls.Add(this.pictureBox2);
            this.loginPanel.Controls.Add(this.username_txt);
            this.loginPanel.Controls.Add(this.sub_btn);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.password_txt);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.greetingPanel);
            this.loginPanel.Location = new System.Drawing.Point(28, 20);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(649, 380);
            this.loginPanel.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(234, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // username_txt
            // 
            this.username_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username_txt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_txt.Location = new System.Drawing.Point(229, 207);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(198, 32);
            this.username_txt.TabIndex = 12;
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sub_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sub_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub_btn.Location = new System.Drawing.Point(479, 221);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(156, 43);
            this.sub_btn.TabIndex = 15;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = false;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(31, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // password_txt
            // 
            this.password_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password_txt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_txt.Location = new System.Drawing.Point(229, 256);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(198, 32);
            this.password_txt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mot de Passe";
            // 
            // greetingPanel
            // 
            this.greetingPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.greetingPanel.Controls.Add(this.hello_lbl);
            this.greetingPanel.Controls.Add(this.nomBoutique_lbl);
            this.greetingPanel.Location = new System.Drawing.Point(45, 45);
            this.greetingPanel.Name = "greetingPanel";
            this.greetingPanel.Size = new System.Drawing.Size(556, 314);
            this.greetingPanel.TabIndex = 1;
            this.greetingPanel.Visible = false;
            // 
            // hello_lbl
            // 
            this.hello_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hello_lbl.AutoSize = true;
            this.hello_lbl.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hello_lbl.ForeColor = System.Drawing.Color.MediumOrchid;
            this.hello_lbl.Location = new System.Drawing.Point(233, 84);
            this.hello_lbl.Name = "hello_lbl";
            this.hello_lbl.Size = new System.Drawing.Size(153, 43);
            this.hello_lbl.TabIndex = 1;
            this.hello_lbl.Text = "Bonjour";
            // 
            // nomBoutique_lbl
            // 
            this.nomBoutique_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomBoutique_lbl.AutoSize = true;
            this.nomBoutique_lbl.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomBoutique_lbl.ForeColor = System.Drawing.Color.MediumOrchid;
            this.nomBoutique_lbl.Location = new System.Drawing.Point(250, 11);
            this.nomBoutique_lbl.Name = "nomBoutique_lbl";
            this.nomBoutique_lbl.Size = new System.Drawing.Size(132, 46);
            this.nomBoutique_lbl.TabIndex = 0;
            this.nomBoutique_lbl.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Gestionnaire_Pro.Properties.Resources.rmdaTem;
            this.pictureBox1.Location = new System.Drawing.Point(101, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 53);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créer par Derrar Mourad Riad ,N°Téléphone :  0799244307";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 581);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.buttonsPanel);
            this.MinimumSize = new System.Drawing.Size(962, 620);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.greetingPanel.ResumeLayout(false);
            this.greetingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        //-------------------------------------------------------------events methodes begin-------------------------------------------------------
        private void addArticleDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new ajouteArticle())
            {
                form.ShowDialog();
            }
        }

        private void listAchatDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new listeAchat())
            {
                form.ShowDialog();
            }
        }

        private void listAchatDropItem_Check(object sender, EventArgs e)
        {
            using (var form = new listeAchat())
            {
                form.ShowDialog();
            }
        }

        private void nvAchatDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new ajouteAchat())
            {
                form.ShowDialog();
            }
        }

        private void historyVenteDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new historiqueVente())
            {
                form.ShowDialog();
            }
        }

        private void nvVenteDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new vente())
            {
                form.ShowDialog();
            }
        }

        private void quitDropList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutDropList_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void addFournisseurDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new ajouteFournisseur())
            {
                form.ShowDialog();
            }
        }

        private void listFournisseurDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new TableFournisseur())
            {
                form.ShowDialog();
            }
        }

        private void revenueDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new revenue())
            {
                form.ShowDialog();
            }
        }

        
        private void caisseDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new caisse())
            {
                form.ShowDialog();
            }
        }

        private void utilisateurDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new utilisateur())
            {
                form.ShowDialog();
            }
        }

        private void infoBoutiqueDropList_Click(object sender, EventArgs e)
        {
            var form = new infosBoutique();
            
                form.ShowDialog();
            
        }

        private void addClientDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new ajouteClient())
            {
                form.ShowDialog();
            }
        }

        private void parametreDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new param())
            {
                form.ShowDialog();
            }
        }

        //Event Handlers
        private void listClientsDropItem_Click(object sender, EventArgs e)
        {
            using (var form = new listeClient())
            {
                form.ShowDialog();
            }
        }

        //------------------------------------------------------------------------------------ events methodes end------------------------------------------
        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button vente_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button articles_btn;
        private System.Windows.Forms.Button achat_btn;
        private System.Windows.Forms.Button rev_btn;
        private System.Windows.Forms.Button actions_btn;
        private System.Windows.Forms.Button notification_btn;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Button fournisseurs_btn;
        private System.Windows.Forms.Button clients_btn;
        private System.Windows.Forms.Label logoLbl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button exitChildForm_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel greetingPanel;
        private System.Windows.Forms.Label hello_lbl;
        private System.Windows.Forms.Label nomBoutique_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

