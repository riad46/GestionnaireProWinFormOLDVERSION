
namespace Gestionnaire_Pro
{
    partial class ArticlesTotalStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticlesTotalStatistics));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codeBarre_txt = new System.Windows.Forms.TextBox();
            this.nomArticle_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomF_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.articleTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixACol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.codeBarre_txt);
            this.panel1.Controls.Add(this.nomArticle_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.type_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nomF_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 148);
            this.panel1.TabIndex = 1;
            // 
            // codeBarre_txt
            // 
            this.codeBarre_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeBarre_txt.Location = new System.Drawing.Point(134, 12);
            this.codeBarre_txt.Name = "codeBarre_txt";
            this.codeBarre_txt.Size = new System.Drawing.Size(154, 32);
            this.codeBarre_txt.TabIndex = 23;
            this.codeBarre_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // nomArticle_txt
            // 
            this.nomArticle_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomArticle_txt.Location = new System.Drawing.Point(488, 12);
            this.nomArticle_txt.Name = "nomArticle_txt";
            this.nomArticle_txt.Size = new System.Drawing.Size(154, 32);
            this.nomArticle_txt.TabIndex = 24;
            this.nomArticle_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "CodeBarre";
            // 
            // type_txt
            // 
            this.type_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type_txt.Location = new System.Drawing.Point(132, 64);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(154, 32);
            this.type_txt.TabIndex = 25;
            this.type_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(319, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom Fournisseur";
            // 
            // nomF_txt
            // 
            this.nomF_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomF_txt.Location = new System.Drawing.Point(488, 69);
            this.nomF_txt.Name = "nomF_txt";
            this.nomF_txt.Size = new System.Drawing.Size(154, 32);
            this.nomF_txt.TabIndex = 26;
            this.nomF_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(319, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Type";
            // 
            // articleTable
            // 
            this.articleTable.AllowUserToAddRows = false;
            this.articleTable.AllowUserToDeleteRows = false;
            this.articleTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.articleTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.articleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleTable.BackgroundColor = System.Drawing.Color.White;
            this.articleTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.articleTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.articleTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.articleTable.ColumnHeadersHeight = 60;
            this.articleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.articleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.codeBarre,
            this.nomCol,
            this.typeCol,
            this.qntCol,
            this.prixACol,
            this.prixVCol,
            this.TotalPayé,
            this.totalVente,
            this.Revenue});
            this.articleTable.EnableHeadersVisualStyles = false;
            this.articleTable.GridColor = System.Drawing.Color.White;
            this.articleTable.Location = new System.Drawing.Point(12, 154);
            this.articleTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.articleTable.MultiSelect = false;
            this.articleTable.Name = "articleTable";
            this.articleTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.articleTable.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.articleTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.articleTable.RowTemplate.Height = 40;
            this.articleTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articleTable.Size = new System.Drawing.Size(795, 404);
            this.articleTable.TabIndex = 2;
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
            // TotalPayé
            // 
            this.TotalPayé.HeaderText = "Total Achat";
            this.TotalPayé.Name = "TotalPayé";
            this.TotalPayé.ReadOnly = true;
            // 
            // totalVente
            // 
            this.totalVente.HeaderText = "Total de Vente";
            this.totalVente.Name = "totalVente";
            this.totalVente.ReadOnly = true;
            // 
            // Revenue
            // 
            this.Revenue.HeaderText = "Revenue Net";
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            // 
            // ArticlesTotalStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 576);
            this.Controls.Add(this.articleTable);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticlesTotalStatistics";
            this.Text = "Statistiques d\'articles";
            this.Load += new System.EventHandler(this.ArticlesTotalStatistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView articleTable;
        private System.Windows.Forms.TextBox codeBarre_txt;
        private System.Windows.Forms.TextBox nomArticle_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomF_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixACol;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPayé;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
    }
}