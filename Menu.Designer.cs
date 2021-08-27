
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
            this.gradiantPanel1 = new Gestionnaire_Pro.GradiantPanel();
            this.listArticlesLabel = new System.Windows.Forms.Label();
            this.historiqueVenteLabel = new System.Windows.Forms.Label();
            this.venteLabel = new System.Windows.Forms.Label();
            this.articlesList_pic = new System.Windows.Forms.PictureBox();
            this.historiqueVente_pic = new System.Windows.Forms.PictureBox();
            this.nvVente_pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitDropList = new System.Windows.Forms.ToolStripMenuItem();
            this.achatItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvAchatDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableDAchatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvVenteDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyVenteDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factureItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutFactureDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableFactureDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableDArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableDArticlesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listClientsDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableDeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paimentDeCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFournisseurDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listFournisseurDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caisseDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoBoutiqueDropList = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreDropItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradiantPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesList_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiqueVente_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvVente_pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.angle = 0F;
            this.gradiantPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradiantPanel1.Controls.Add(this.listArticlesLabel);
            this.gradiantPanel1.Controls.Add(this.historiqueVenteLabel);
            this.gradiantPanel1.Controls.Add(this.venteLabel);
            this.gradiantPanel1.Controls.Add(this.articlesList_pic);
            this.gradiantPanel1.Controls.Add(this.historiqueVente_pic);
            this.gradiantPanel1.Controls.Add(this.nvVente_pic);
            this.gradiantPanel1.Controls.Add(this.menuStrip1);
            this.gradiantPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradiantPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradiantPanel1.lowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(1215, 690);
            this.gradiantPanel1.TabIndex = 0;
            this.gradiantPanel1.topColor = System.Drawing.Color.Red;
            // 
            // listArticlesLabel
            // 
            this.listArticlesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listArticlesLabel.AutoSize = true;
            this.listArticlesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listArticlesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listArticlesLabel.Location = new System.Drawing.Point(845, 545);
            this.listArticlesLabel.Name = "listArticlesLabel";
            this.listArticlesLabel.Size = new System.Drawing.Size(163, 32);
            this.listArticlesLabel.TabIndex = 9;
            this.listArticlesLabel.Text = "Liste d\'articles";
            this.listArticlesLabel.Click += new System.EventHandler(this.listArticlesLabel_Click);
            // 
            // historiqueVenteLabel
            // 
            this.historiqueVenteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.historiqueVenteLabel.AutoSize = true;
            this.historiqueVenteLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historiqueVenteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historiqueVenteLabel.Location = new System.Drawing.Point(488, 545);
            this.historiqueVenteLabel.Name = "historiqueVenteLabel";
            this.historiqueVenteLabel.Size = new System.Drawing.Size(226, 32);
            this.historiqueVenteLabel.TabIndex = 8;
            this.historiqueVenteLabel.Text = "Historique de Vente";
            this.historiqueVenteLabel.Click += new System.EventHandler(this.historiqueVenteLabel_Click);
            // 
            // venteLabel
            // 
            this.venteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.venteLabel.AutoSize = true;
            this.venteLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.venteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.venteLabel.Location = new System.Drawing.Point(186, 545);
            this.venteLabel.Name = "venteLabel";
            this.venteLabel.Size = new System.Drawing.Size(179, 32);
            this.venteLabel.TabIndex = 7;
            this.venteLabel.Text = "Nouveau Vente";
            this.venteLabel.Click += new System.EventHandler(this.venteLabel_Click);
            // 
            // articlesList_pic
            // 
            this.articlesList_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articlesList_pic.BackColor = System.Drawing.Color.Transparent;
            this.articlesList_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.articlesList_pic.Image = global::Gestionnaire_Pro.Properties.Resources.cosmetics;
            this.articlesList_pic.Location = new System.Drawing.Point(792, 230);
            this.articlesList_pic.MaximumSize = new System.Drawing.Size(300, 300);
            this.articlesList_pic.MinimumSize = new System.Drawing.Size(150, 150);
            this.articlesList_pic.Name = "articlesList_pic";
            this.articlesList_pic.Size = new System.Drawing.Size(273, 290);
            this.articlesList_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.articlesList_pic.TabIndex = 6;
            this.articlesList_pic.TabStop = false;
            this.articlesList_pic.Click += new System.EventHandler(this.articlesList_pic_Click);
            // 
            // historiqueVente_pic
            // 
            this.historiqueVente_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.historiqueVente_pic.BackColor = System.Drawing.Color.Transparent;
            this.historiqueVente_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historiqueVente_pic.Image = global::Gestionnaire_Pro.Properties.Resources.history;
            this.historiqueVente_pic.Location = new System.Drawing.Point(461, 230);
            this.historiqueVente_pic.MaximumSize = new System.Drawing.Size(300, 300);
            this.historiqueVente_pic.MinimumSize = new System.Drawing.Size(150, 150);
            this.historiqueVente_pic.Name = "historiqueVente_pic";
            this.historiqueVente_pic.Size = new System.Drawing.Size(273, 290);
            this.historiqueVente_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.historiqueVente_pic.TabIndex = 5;
            this.historiqueVente_pic.TabStop = false;
            this.historiqueVente_pic.Click += new System.EventHandler(this.historiqueVente_pic_Click);
            // 
            // nvVente_pic
            // 
            this.nvVente_pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nvVente_pic.BackColor = System.Drawing.Color.Transparent;
            this.nvVente_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nvVente_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nvVente_pic.Image = global::Gestionnaire_Pro.Properties.Resources.shopping_basket;
            this.nvVente_pic.Location = new System.Drawing.Point(136, 230);
            this.nvVente_pic.MaximumSize = new System.Drawing.Size(300, 300);
            this.nvVente_pic.MinimumSize = new System.Drawing.Size(150, 150);
            this.nvVente_pic.Name = "nvVente_pic";
            this.nvVente_pic.Size = new System.Drawing.Size(273, 290);
            this.nvVente_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nvVente_pic.TabIndex = 4;
            this.nvVente_pic.TabStop = false;
            this.nvVente_pic.Click += new System.EventHandler(this.nvVente_pic_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierItem,
            this.achatItem,
            this.venteItem,
            this.factureItem,
            this.articleItem,
            this.clientItem,
            this.fournisseurItem,
            this.extrasItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierItem
            // 
            this.fichierItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitDropList});
            this.fichierItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fichierItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.fichierItem.Name = "fichierItem";
            this.fichierItem.Size = new System.Drawing.Size(91, 29);
            this.fichierItem.Text = "Fichier";
            // 
            // quitDropList
            // 
            this.quitDropList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitDropList.Name = "quitDropList";
            this.quitDropList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitDropList.Size = new System.Drawing.Size(185, 24);
            this.quitDropList.Text = "Quitter";
            this.quitDropList.Click += new System.EventHandler(this.quitDropList_Click_1);
            // 
            // achatItem
            // 
            this.achatItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nvAchatDropItem,
            this.tableDAchatsToolStripMenuItem});
            this.achatItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.achatItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.achatItem.Name = "achatItem";
            this.achatItem.Size = new System.Drawing.Size(79, 29);
            this.achatItem.Text = "Achat";
            this.achatItem.Click += new System.EventHandler(this.achatItem_Click);
            // 
            // nvAchatDropItem
            // 
            this.nvAchatDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nvAchatDropItem.Name = "nvAchatDropItem";
            this.nvAchatDropItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.nvAchatDropItem.Size = new System.Drawing.Size(224, 30);
            this.nvAchatDropItem.Text = "Nouveau Achat";
            this.nvAchatDropItem.Click += new System.EventHandler(this.nvAchatDropItem_Click_1);
            // 
            // tableDAchatsToolStripMenuItem
            // 
            this.tableDAchatsToolStripMenuItem.Name = "tableDAchatsToolStripMenuItem";
            this.tableDAchatsToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.tableDAchatsToolStripMenuItem.Text = "Table d\'Achats";
            this.tableDAchatsToolStripMenuItem.Click += new System.EventHandler(this.tableDAchatsToolStripMenuItem_Click);
            // 
            // venteItem
            // 
            this.venteItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nvVenteDropItem,
            this.historyVenteDropItem});
            this.venteItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.venteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.venteItem.Name = "venteItem";
            this.venteItem.Size = new System.Drawing.Size(76, 29);
            this.venteItem.Text = "Vente";
            // 
            // nvVenteDropItem
            // 
            this.nvVenteDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nvVenteDropItem.Name = "nvVenteDropItem";
            this.nvVenteDropItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.nvVenteDropItem.Size = new System.Drawing.Size(253, 22);
            this.nvVenteDropItem.Text = "Nouvelle Vente";
            this.nvVenteDropItem.Click += new System.EventHandler(this.nvVenteDropItem_Click_1);
            // 
            // historyVenteDropItem
            // 
            this.historyVenteDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.historyVenteDropItem.Name = "historyVenteDropItem";
            this.historyVenteDropItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.historyVenteDropItem.Size = new System.Drawing.Size(253, 22);
            this.historyVenteDropItem.Text = "Historique de Vente";
            this.historyVenteDropItem.Click += new System.EventHandler(this.historyVenteDropItem_Click_1);
            // 
            // factureItem
            // 
            this.factureItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutFactureDropItem,
            this.tableFactureDropItem});
            this.factureItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.factureItem.ForeColor = System.Drawing.Color.Red;
            this.factureItem.Name = "factureItem";
            this.factureItem.Size = new System.Drawing.Size(97, 29);
            this.factureItem.Text = "Facture";
            this.factureItem.Visible = false;
            // 
            // ajoutFactureDropItem
            // 
            this.ajoutFactureDropItem.Name = "ajoutFactureDropItem";
            this.ajoutFactureDropItem.Size = new System.Drawing.Size(274, 30);
            this.ajoutFactureDropItem.Text = "Ajouter une Facture";
            // 
            // tableFactureDropItem
            // 
            this.tableFactureDropItem.Name = "tableFactureDropItem";
            this.tableFactureDropItem.Size = new System.Drawing.Size(274, 30);
            this.tableFactureDropItem.Text = "Table de factures";
            // 
            // articleItem
            // 
            this.articleItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableDArticlesToolStripMenuItem,
            this.listeDArticleToolStripMenuItem,
            this.tableDArticlesToolStripMenuItem1});
            this.articleItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.articleItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.articleItem.Name = "articleItem";
            this.articleItem.Size = new System.Drawing.Size(87, 29);
            this.articleItem.Text = "Article";
            // 
            // tableDArticlesToolStripMenuItem
            // 
            this.tableDArticlesToolStripMenuItem.Name = "tableDArticlesToolStripMenuItem";
            this.tableDArticlesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.tableDArticlesToolStripMenuItem.Text = "Ajouter Article";
            this.tableDArticlesToolStripMenuItem.Click += new System.EventHandler(this.tableDArticlesToolStripMenuItem_Click);
            // 
            // listeDArticleToolStripMenuItem
            // 
            this.listeDArticleToolStripMenuItem.Name = "listeDArticleToolStripMenuItem";
            this.listeDArticleToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.listeDArticleToolStripMenuItem.Text = "Liste d\'Article";
            this.listeDArticleToolStripMenuItem.Click += new System.EventHandler(this.listeDArticleToolStripMenuItem_Click);
            // 
            // tableDArticlesToolStripMenuItem1
            // 
            this.tableDArticlesToolStripMenuItem1.Name = "tableDArticlesToolStripMenuItem1";
            this.tableDArticlesToolStripMenuItem1.Size = new System.Drawing.Size(232, 30);
            this.tableDArticlesToolStripMenuItem1.Text = "Table d\'Articles";
            this.tableDArticlesToolStripMenuItem1.Click += new System.EventHandler(this.tableDArticlesToolStripMenuItem1_Click);
            // 
            // clientItem
            // 
            this.clientItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientDropItem,
            this.listClientsDropItem,
            this.gérerLesClientsToolStripMenuItem});
            this.clientItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.clientItem.Name = "clientItem";
            this.clientItem.Size = new System.Drawing.Size(81, 29);
            this.clientItem.Text = "Client";
            // 
            // addClientDropItem
            // 
            this.addClientDropItem.Name = "addClientDropItem";
            this.addClientDropItem.Size = new System.Drawing.Size(236, 30);
            this.addClientDropItem.Text = "Nouveau Client";
            this.addClientDropItem.Click += new System.EventHandler(this.addClientDropItem_Click_1);
            // 
            // listClientsDropItem
            // 
            this.listClientsDropItem.Name = "listClientsDropItem";
            this.listClientsDropItem.Size = new System.Drawing.Size(236, 30);
            this.listClientsDropItem.Text = "Liste de Clients";
            this.listClientsDropItem.Click += new System.EventHandler(this.listClientsDropItem_Click_1);
            // 
            // gérerLesClientsToolStripMenuItem
            // 
            this.gérerLesClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableDeClientToolStripMenuItem,
            this.ajouterCreditToolStripMenuItem,
            this.paimentDeCreditToolStripMenuItem});
            this.gérerLesClientsToolStripMenuItem.Name = "gérerLesClientsToolStripMenuItem";
            this.gérerLesClientsToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.gérerLesClientsToolStripMenuItem.Text = "Gérer les clients";
            // 
            // tableDeClientToolStripMenuItem
            // 
            this.tableDeClientToolStripMenuItem.Name = "tableDeClientToolStripMenuItem";
            this.tableDeClientToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.tableDeClientToolStripMenuItem.Text = "Table de Client";
            this.tableDeClientToolStripMenuItem.Click += new System.EventHandler(this.tableDeClientToolStripMenuItem_Click);
            // 
            // ajouterCreditToolStripMenuItem
            // 
            this.ajouterCreditToolStripMenuItem.Name = "ajouterCreditToolStripMenuItem";
            this.ajouterCreditToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.ajouterCreditToolStripMenuItem.Text = "Ajouter Credit";
            this.ajouterCreditToolStripMenuItem.Click += new System.EventHandler(this.ajouterCreditToolStripMenuItem_Click);
            // 
            // paimentDeCreditToolStripMenuItem
            // 
            this.paimentDeCreditToolStripMenuItem.Name = "paimentDeCreditToolStripMenuItem";
            this.paimentDeCreditToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.paimentDeCreditToolStripMenuItem.Text = "Paiment de Credit";
            this.paimentDeCreditToolStripMenuItem.Click += new System.EventHandler(this.paimentDeCreditToolStripMenuItem_Click);
            // 
            // fournisseurItem
            // 
            this.fournisseurItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFournisseurDropItem,
            this.listFournisseurDropItem,
            this.tableFournisseursToolStripMenuItem});
            this.fournisseurItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fournisseurItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.fournisseurItem.Name = "fournisseurItem";
            this.fournisseurItem.Size = new System.Drawing.Size(137, 29);
            this.fournisseurItem.Text = "Fournisseur";
            // 
            // addFournisseurDropItem
            // 
            this.addFournisseurDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addFournisseurDropItem.Name = "addFournisseurDropItem";
            this.addFournisseurDropItem.Size = new System.Drawing.Size(264, 30);
            this.addFournisseurDropItem.Text = "Nouveau Fournisseur";
            this.addFournisseurDropItem.Click += new System.EventHandler(this.addFournisseurDropItem_Click_1);
            // 
            // listFournisseurDropItem
            // 
            this.listFournisseurDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listFournisseurDropItem.Name = "listFournisseurDropItem";
            this.listFournisseurDropItem.Size = new System.Drawing.Size(264, 30);
            this.listFournisseurDropItem.Text = "Liste de Fournisseurs";
            this.listFournisseurDropItem.Click += new System.EventHandler(this.listFournisseurDropItem_Click_1);
            // 
            // tableFournisseursToolStripMenuItem
            // 
            this.tableFournisseursToolStripMenuItem.Name = "tableFournisseursToolStripMenuItem";
            this.tableFournisseursToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.tableFournisseursToolStripMenuItem.Text = "Table Fournisseurs";
            this.tableFournisseursToolStripMenuItem.Click += new System.EventHandler(this.tableFournisseursToolStripMenuItem_Click);
            // 
            // extrasItem
            // 
            this.extrasItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueDropItem,
            this.caisseDropItem,
            this.utilisateurDropItem,
            this.infoBoutiqueDropList,
            this.parametreDropItem});
            this.extrasItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.extrasItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.extrasItem.Name = "extrasItem";
            this.extrasItem.Size = new System.Drawing.Size(86, 29);
            this.extrasItem.Text = "Extras";
            this.extrasItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // revenueDropItem
            // 
            this.revenueDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.revenueDropItem.Name = "revenueDropItem";
            this.revenueDropItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.revenueDropItem.Size = new System.Drawing.Size(279, 22);
            this.revenueDropItem.Text = "Revenue";
            this.revenueDropItem.Click += new System.EventHandler(this.revenueDropItem_Click_1);
            // 
            // caisseDropItem
            // 
            this.caisseDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caisseDropItem.Name = "caisseDropItem";
            this.caisseDropItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.caisseDropItem.Size = new System.Drawing.Size(279, 22);
            this.caisseDropItem.Text = "Caisse";
            this.caisseDropItem.Click += new System.EventHandler(this.caisseDropItem_Click_1);
            // 
            // utilisateurDropItem
            // 
            this.utilisateurDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.utilisateurDropItem.Name = "utilisateurDropItem";
            this.utilisateurDropItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.utilisateurDropItem.Size = new System.Drawing.Size(279, 22);
            this.utilisateurDropItem.Text = "Gérer les Utilisateurs";
            this.utilisateurDropItem.Click += new System.EventHandler(this.utilisateurDropItem_Click_1);
            // 
            // infoBoutiqueDropList
            // 
            this.infoBoutiqueDropList.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoBoutiqueDropList.Name = "infoBoutiqueDropList";
            this.infoBoutiqueDropList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.infoBoutiqueDropList.Size = new System.Drawing.Size(279, 22);
            this.infoBoutiqueDropList.Text = "Information de Boutique";
            this.infoBoutiqueDropList.Click += new System.EventHandler(this.infoBoutiqueDropList_Click_1);
            // 
            // parametreDropItem
            // 
            this.parametreDropItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parametreDropItem.Name = "parametreDropItem";
            this.parametreDropItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.parametreDropItem.Size = new System.Drawing.Size(279, 22);
            this.parametreDropItem.Text = "Paramètre";
            this.parametreDropItem.Visible = false;
            this.parametreDropItem.Click += new System.EventHandler(this.parametreDropItem_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 690);
            this.Controls.Add(this.gradiantPanel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.gradiantPanel1.ResumeLayout(false);
            this.gradiantPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesList_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiqueVente_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvVente_pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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

        private GradiantPanel gradiantPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierItem;
        private System.Windows.Forms.ToolStripMenuItem quitDropList;
        private System.Windows.Forms.ToolStripMenuItem venteItem;
        private System.Windows.Forms.ToolStripMenuItem nvVenteDropItem;
        private System.Windows.Forms.ToolStripMenuItem historyVenteDropItem;
        private System.Windows.Forms.ToolStripMenuItem achatItem;
        private System.Windows.Forms.ToolStripMenuItem nvAchatDropItem;
        private System.Windows.Forms.ToolStripMenuItem articleItem;
        private System.Windows.Forms.ToolStripMenuItem clientItem;
        private System.Windows.Forms.ToolStripMenuItem addClientDropItem;
        private System.Windows.Forms.ToolStripMenuItem listClientsDropItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurItem;
        private System.Windows.Forms.ToolStripMenuItem addFournisseurDropItem;
        private System.Windows.Forms.ToolStripMenuItem listFournisseurDropItem;
        private System.Windows.Forms.ToolStripMenuItem extrasItem;
        private System.Windows.Forms.ToolStripMenuItem revenueDropItem;
        private System.Windows.Forms.ToolStripMenuItem caisseDropItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurDropItem;
        private System.Windows.Forms.ToolStripMenuItem infoBoutiqueDropList;
        private System.Windows.Forms.ToolStripMenuItem parametreDropItem;
        private System.Windows.Forms.ToolStripMenuItem tableDArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableDArticlesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gérerLesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableDeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paimentDeCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableDAchatsToolStripMenuItem;
        private System.Windows.Forms.PictureBox articlesList_pic;
        private System.Windows.Forms.PictureBox historiqueVente_pic;
        private System.Windows.Forms.PictureBox nvVente_pic;
        private System.Windows.Forms.Label listArticlesLabel;
        private System.Windows.Forms.Label historiqueVenteLabel;
        private System.Windows.Forms.Label venteLabel;
        private System.Windows.Forms.ToolStripMenuItem factureItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutFactureDropItem;
        private System.Windows.Forms.ToolStripMenuItem tableFactureDropItem;
    }
}

