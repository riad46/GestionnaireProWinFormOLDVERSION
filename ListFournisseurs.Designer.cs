
namespace Gestionnaire_Pro
{
    partial class ListFournisseurs
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
            this.num_txt = new System.Windows.Forms.TextBox();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.credit_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fournisseurTable = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.num_txt);
            this.panel1.Controls.Add(this.nom_txt);
            this.panel1.Controls.Add(this.credit_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 142);
            this.panel1.TabIndex = 0;
            // 
            // num_txt
            // 
            this.num_txt.Location = new System.Drawing.Point(201, 51);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(136, 23);
            this.num_txt.TabIndex = 5;
            this.num_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // nom_txt
            // 
            this.nom_txt.Location = new System.Drawing.Point(201, 8);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(136, 23);
            this.nom_txt.TabIndex = 4;
            this.nom_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // credit_txt
            // 
            this.credit_txt.Location = new System.Drawing.Point(201, 99);
            this.credit_txt.Name = "credit_txt";
            this.credit_txt.Size = new System.Drawing.Size(93, 23);
            this.credit_txt.TabIndex = 3;
            this.credit_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crédit A rendre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Téléphone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // fournisseurTable
            // 
            this.fournisseurTable.AllowUserToAddRows = false;
            this.fournisseurTable.AllowUserToDeleteRows = false;
            this.fournisseurTable.AllowUserToOrderColumns = true;
            this.fournisseurTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fournisseurTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fournisseurTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.fournisseurTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fournisseurTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.num,
            this.Address,
            this.Column1});
            this.fournisseurTable.Location = new System.Drawing.Point(0, 152);
            this.fournisseurTable.Name = "fournisseurTable";
            this.fournisseurTable.ReadOnly = true;
            this.fournisseurTable.RowTemplate.Height = 25;
            this.fournisseurTable.Size = new System.Drawing.Size(497, 384);
            this.fournisseurTable.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // num
            // 
            this.num.DataPropertyName = "numTlf";
            this.num.HeaderText = "N° Téléphone";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "creditArendre";
            this.Column1.HeaderText = "Crédit a Rendre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ListFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 548);
            this.Controls.Add(this.fournisseurTable);
            this.Controls.Add(this.panel1);
            this.Name = "ListFournisseurs";
            this.Text = "ListFournisseurs";
            this.Load += new System.EventHandler(this.ListFournisseurs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView fournisseurTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox num_txt;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.TextBox credit_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}