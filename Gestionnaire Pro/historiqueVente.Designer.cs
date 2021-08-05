
namespace Gestionnaire_Pro
{
    partial class historiqueVente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.historique_Table = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVenteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetpayéCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifierLeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NvtotaleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvRemise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.historique_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historique_Table
            // 
            this.historique_Table.AllowUserToAddRows = false;
            this.historique_Table.AllowUserToDeleteRows = false;
            this.historique_Table.AllowUserToOrderColumns = true;
            this.historique_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historique_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historique_Table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historique_Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.historique_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.historique_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historique_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.DateVenteCol,
            this.totalCol,
            this.remiseCol,
            this.NetpayéCol,
            this.clientCol,
            this.userCol,
            this.modifierLeCol,
            this.NvtotaleCol,
            this.nvRemise,
            this.nvNetCol});
            this.historique_Table.Cursor = System.Windows.Forms.Cursors.Default;
            this.historique_Table.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.historique_Table.Location = new System.Drawing.Point(0, 190);
            this.historique_Table.Name = "historique_Table";
            this.historique_Table.ReadOnly = true;
            this.historique_Table.RowTemplate.Height = 25;
            this.historique_Table.Size = new System.Drawing.Size(1045, 569);
            this.historique_Table.TabIndex = 0;
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "Id";
            this.idCol.HeaderText = "Réf";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            // 
            // DateVenteCol
            // 
            this.DateVenteCol.DataPropertyName = "dateVente";
            this.DateVenteCol.HeaderText = "Date Vente";
            this.DateVenteCol.Name = "DateVenteCol";
            this.DateVenteCol.ReadOnly = true;
            // 
            // totalCol
            // 
            this.totalCol.DataPropertyName = "montantTotal";
            this.totalCol.HeaderText = "Montant Total";
            this.totalCol.Name = "totalCol";
            this.totalCol.ReadOnly = true;
            // 
            // remiseCol
            // 
            this.remiseCol.DataPropertyName = "remise";
            this.remiseCol.HeaderText = "Remise";
            this.remiseCol.Name = "remiseCol";
            this.remiseCol.ReadOnly = true;
            // 
            // NetpayéCol
            // 
            this.NetpayéCol.DataPropertyName = "netAPayé";
            this.NetpayéCol.HeaderText = "Net Payé";
            this.NetpayéCol.Name = "NetpayéCol";
            this.NetpayéCol.ReadOnly = true;
            // 
            // clientCol
            // 
            this.clientCol.HeaderText = "Client";
            this.clientCol.Name = "clientCol";
            this.clientCol.ReadOnly = true;
            // 
            // userCol
            // 
            this.userCol.DataPropertyName = "ajouterPar";
            this.userCol.HeaderText = "Ajouter Par";
            this.userCol.Name = "userCol";
            this.userCol.ReadOnly = true;
            // 
            // modifierLeCol
            // 
            this.modifierLeCol.DataPropertyName = "dateModification";
            this.modifierLeCol.HeaderText = "Modifier Le";
            this.modifierLeCol.Name = "modifierLeCol";
            this.modifierLeCol.ReadOnly = true;
            // 
            // NvtotaleCol
            // 
            this.NvtotaleCol.DataPropertyName = "modifierPar";
            this.NvtotaleCol.HeaderText = "Nouveau Total";
            this.NvtotaleCol.Name = "NvtotaleCol";
            this.NvtotaleCol.ReadOnly = true;
            // 
            // nvRemise
            // 
            this.nvRemise.DataPropertyName = "nouvelleRemise";
            this.nvRemise.HeaderText = "Nouvelle Remise";
            this.nvRemise.Name = "nvRemise";
            this.nvRemise.ReadOnly = true;
            // 
            // nvNetCol
            // 
            this.nvNetCol.DataPropertyName = "NouveauNetAPayé";
            this.nvNetCol.HeaderText = "Nouveau Net Payé";
            this.nvNetCol.Name = "nvNetCol";
            this.nvNetCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 184);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(700, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // historiqueVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historique_Table);
            this.Name = "historiqueVente";
            this.Text = "historyVente";
            this.Load += new System.EventHandler(this.historiqueVente_Load);
            this.Resize += new System.EventHandler(this.historiqueVente_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.historique_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historique_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVenteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetpayéCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifierLeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NvtotaleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvRemise;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNetCol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}