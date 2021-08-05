
namespace Gestionnaire_Pro
{
    partial class tableArticle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.articleTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reset_Stock = new System.Windows.Forms.Button();
            this.FullRevenue_btn = new System.Windows.Forms.Button();
            this.deleteAll_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixACol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomFournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // articleTable
            // 
            this.articleTable.AllowUserToAddRows = false;
            this.articleTable.AllowUserToDeleteRows = false;
            this.articleTable.AllowUserToOrderColumns = true;
            this.articleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.articleTable.BackgroundColor = System.Drawing.Color.Azure;
            this.articleTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.articleTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.articleTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.codeBarre,
            this.nomCol,
            this.typeCol,
            this.qntCol,
            this.prixACol,
            this.prixVCol,
            this.dateCol,
            this.NomFournisseur});
            this.articleTable.Location = new System.Drawing.Point(0, 0);
            this.articleTable.MultiSelect = false;
            this.articleTable.Name = "articleTable";
            this.articleTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.articleTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.articleTable.RowTemplate.Height = 25;
            this.articleTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articleTable.Size = new System.Drawing.Size(806, 535);
            this.articleTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.reset_Stock);
            this.panel1.Controls.Add(this.FullRevenue_btn);
            this.panel1.Controls.Add(this.deleteAll_btn);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.modify_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Location = new System.Drawing.Point(809, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 532);
            this.panel1.TabIndex = 1;
            // 
            // reset_Stock
            // 
            this.reset_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_Stock.Location = new System.Drawing.Point(0, 285);
            this.reset_Stock.Name = "reset_Stock";
            this.reset_Stock.Size = new System.Drawing.Size(153, 45);
            this.reset_Stock.TabIndex = 16;
            this.reset_Stock.Text = "Reset Stock";
            this.reset_Stock.UseVisualStyleBackColor = true;
            this.reset_Stock.Click += new System.EventHandler(this.reset_Stock_Click);
            // 
            // FullRevenue_btn
            // 
            this.FullRevenue_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FullRevenue_btn.Location = new System.Drawing.Point(3, 477);
            this.FullRevenue_btn.Name = "FullRevenue_btn";
            this.FullRevenue_btn.Size = new System.Drawing.Size(153, 45);
            this.FullRevenue_btn.TabIndex = 15;
            this.FullRevenue_btn.Text = "Voir Revenue Total";
            this.FullRevenue_btn.UseVisualStyleBackColor = true;
            // 
            // deleteAll_btn
            // 
            this.deleteAll_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAll_btn.Location = new System.Drawing.Point(3, 193);
            this.deleteAll_btn.Name = "deleteAll_btn";
            this.deleteAll_btn.Size = new System.Drawing.Size(153, 45);
            this.deleteAll_btn.TabIndex = 14;
            this.deleteAll_btn.Text = "Supprimer Tout";
            this.deleteAll_btn.UseVisualStyleBackColor = true;
            this.deleteAll_btn.Click += new System.EventHandler(this.deleteAll_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Location = new System.Drawing.Point(3, 130);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(153, 45);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Supprimer";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_btn.Location = new System.Drawing.Point(3, 70);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(153, 45);
            this.modify_btn.TabIndex = 12;
            this.modify_btn.Text = "Modifier";
            this.modify_btn.UseVisualStyleBackColor = true;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Location = new System.Drawing.Point(3, 11);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(153, 45);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Ajouter";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "id";
            this.idCol.HeaderText = "Réf";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // codeBarre
            // 
            this.codeBarre.DataPropertyName = "codeBarre";
            this.codeBarre.HeaderText = "Code Barre";
            this.codeBarre.Name = "codeBarre";
            this.codeBarre.ReadOnly = true;
            // 
            // nomCol
            // 
            this.nomCol.DataPropertyName = "nom";
            this.nomCol.HeaderText = "Nom";
            this.nomCol.Name = "nomCol";
            this.nomCol.ReadOnly = true;
            // 
            // typeCol
            // 
            this.typeCol.DataPropertyName = "type";
            this.typeCol.HeaderText = "Type";
            this.typeCol.Name = "typeCol";
            this.typeCol.ReadOnly = true;
            this.typeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // qntCol
            // 
            this.qntCol.DataPropertyName = "quantité";
            this.qntCol.HeaderText = "Quantité";
            this.qntCol.Name = "qntCol";
            this.qntCol.ReadOnly = true;
            this.qntCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prixACol
            // 
            this.prixACol.DataPropertyName = "prixAchat";
            this.prixACol.HeaderText = "prix d\'Achat";
            this.prixACol.Name = "prixACol";
            this.prixACol.ReadOnly = true;
            // 
            // prixVCol
            // 
            this.prixVCol.DataPropertyName = "prixVente";
            this.prixVCol.HeaderText = "Prix de Vente";
            this.prixVCol.Name = "prixVCol";
            this.prixVCol.ReadOnly = true;
            // 
            // dateCol
            // 
            this.dateCol.DataPropertyName = "dateExpiration";
            this.dateCol.HeaderText = "Date d\'Expiration";
            this.dateCol.Name = "dateCol";
            this.dateCol.ReadOnly = true;
            // 
            // NomFournisseur
            // 
            this.NomFournisseur.DataPropertyName = "Fournisseur.nom";
            this.NomFournisseur.HeaderText = "Nom de Fournisseur";
            this.NomFournisseur.Name = "NomFournisseur";
            this.NomFournisseur.ReadOnly = true;
            // 
            // tableArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.articleTable);
            this.Name = "tableArticle";
            this.Text = "tableArticle";
            this.Load += new System.EventHandler(this.tableArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView articleTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FullRevenue_btn;
        private System.Windows.Forms.Button deleteAll_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button reset_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixACol;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomFournisseur;
    }
}