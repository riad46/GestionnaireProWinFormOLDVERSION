
namespace Gestionnaire_Pro
{
    partial class ListArticle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.codeBarre_txt = new System.Windows.Forms.TextBox();
            this.nomArticle_txt = new System.Windows.Forms.TextBox();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.nomF_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.articleTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.codeBarre_txt);
            this.panel1.Controls.Add(this.nomArticle_txt);
            this.panel1.Controls.Add(this.type_txt);
            this.panel1.Controls.Add(this.nomF_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 151);
            this.panel1.TabIndex = 0;
            // 
            // codeBarre_txt
            // 
            this.codeBarre_txt.Location = new System.Drawing.Point(117, 24);
            this.codeBarre_txt.Name = "codeBarre_txt";
            this.codeBarre_txt.Size = new System.Drawing.Size(185, 23);
            this.codeBarre_txt.TabIndex = 7;
            this.codeBarre_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // nomArticle_txt
            // 
            this.nomArticle_txt.Location = new System.Drawing.Point(117, 68);
            this.nomArticle_txt.Name = "nomArticle_txt";
            this.nomArticle_txt.Size = new System.Drawing.Size(185, 23);
            this.nomArticle_txt.TabIndex = 6;
            this.nomArticle_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // type_txt
            // 
            this.type_txt.Location = new System.Drawing.Point(488, 65);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(185, 23);
            this.type_txt.TabIndex = 5;
            this.type_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // nomF_txt
            // 
            this.nomF_txt.Location = new System.Drawing.Point(488, 24);
            this.nomF_txt.Name = "nomF_txt";
            this.nomF_txt.Size = new System.Drawing.Size(185, 23);
            this.nomF_txt.TabIndex = 4;
            this.nomF_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Fournisseur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodeBarre";
            // 
            // articleTable
            // 
            this.articleTable.AllowUserToAddRows = false;
            this.articleTable.AllowUserToDeleteRows = false;
            this.articleTable.AllowUserToOrderColumns = true;
            this.articleTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.articleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codeBarre,
            this.nom,
            this.qnt,
            this.type,
            this.prixVente,
            this.dateExp,
            this.fournisseur});
            this.articleTable.Location = new System.Drawing.Point(0, 157);
            this.articleTable.MultiSelect = false;
            this.articleTable.Name = "articleTable";
            this.articleTable.ReadOnly = true;
            this.articleTable.RowTemplate.Height = 25;
            this.articleTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articleTable.Size = new System.Drawing.Size(745, 396);
            this.articleTable.TabIndex = 1;
            this.articleTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleTable_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "réf";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codeBarre
            // 
            this.codeBarre.DataPropertyName = "codeBarre";
            this.codeBarre.HeaderText = "CodeBarre";
            this.codeBarre.Name = "codeBarre";
            this.codeBarre.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // qnt
            // 
            this.qnt.DataPropertyName = "quantité";
            this.qnt.HeaderText = "Quantité";
            this.qnt.Name = "qnt";
            this.qnt.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // prixVente
            // 
            this.prixVente.DataPropertyName = "prixVente";
            this.prixVente.HeaderText = "P.U";
            this.prixVente.Name = "prixVente";
            this.prixVente.ReadOnly = true;
            // 
            // dateExp
            // 
            this.dateExp.DataPropertyName = "dateExpiration";
            this.dateExp.HeaderText = "date Expiration";
            this.dateExp.Name = "dateExp";
            this.dateExp.ReadOnly = true;
            // 
            // fournisseur
            // 
            this.fournisseur.HeaderText = "Nom fournisseur ";
            this.fournisseur.Name = "fournisseur";
            this.fournisseur.ReadOnly = true;
            // 
            // ListArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 553);
            this.Controls.Add(this.articleTable);
            this.Controls.Add(this.panel1);
            this.Name = "ListArticle";
            this.Text = "ListArticle";
            this.Load += new System.EventHandler(this.ListArticle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView articleTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeBarre_txt;
        private System.Windows.Forms.TextBox nomArticle_txt;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.TextBox nomF_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fournisseur;
    }
}