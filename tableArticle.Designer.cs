
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
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixACol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomFournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reset_Stock = new System.Windows.Forms.Button();
            this.FullRevenue_btn = new System.Windows.Forms.Button();
            this.deleteAll_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.codeBarre_txt = new System.Windows.Forms.TextBox();
            this.nomArticle_txt = new System.Windows.Forms.TextBox();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.nomF_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.articleTable.Location = new System.Drawing.Point(0, 124);
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
            this.articleTable.Size = new System.Drawing.Size(806, 411);
            this.articleTable.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.codeBarre_txt);
            this.panel2.Controls.Add(this.nomArticle_txt);
            this.panel2.Controls.Add(this.type_txt);
            this.panel2.Controls.Add(this.nomF_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 113);
            this.panel2.TabIndex = 2;
            // 
            // codeBarre_txt
            // 
            this.codeBarre_txt.Location = new System.Drawing.Point(211, 9);
            this.codeBarre_txt.Name = "codeBarre_txt";
            this.codeBarre_txt.Size = new System.Drawing.Size(154, 23);
            this.codeBarre_txt.TabIndex = 15;
            this.codeBarre_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // nomArticle_txt
            // 
            this.nomArticle_txt.Location = new System.Drawing.Point(498, 9);
            this.nomArticle_txt.Name = "nomArticle_txt";
            this.nomArticle_txt.Size = new System.Drawing.Size(154, 23);
            this.nomArticle_txt.TabIndex = 14;
            this.nomArticle_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // type_txt
            // 
            this.type_txt.Location = new System.Drawing.Point(211, 51);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(154, 23);
            this.type_txt.TabIndex = 13;
            this.type_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // nomF_txt
            // 
            this.nomF_txt.Location = new System.Drawing.Point(498, 48);
            this.nomF_txt.Name = "nomF_txt";
            this.nomF_txt.Size = new System.Drawing.Size(154, 23);
            this.nomF_txt.TabIndex = 12;
            this.nomF_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom Fournisseur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "CodeBarre";
            // 
            // tableArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.articleTable);
            this.Name = "tableArticle";
            this.Text = "tableArticle";
            this.Load += new System.EventHandler(this.tableArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox codeBarre_txt;
        private System.Windows.Forms.TextBox nomArticle_txt;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.TextBox nomF_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}