
namespace Gestionnaire_Pro
{
    partial class listeAchat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listeAchat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.del_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.montant_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.achatTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.achatTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.montant_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 108);
            this.panel1.TabIndex = 0;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(484, 64);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(150, 37);
            this.del_btn.TabIndex = 8;
            this.del_btn.Text = "Supprimer";
            this.del_btn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(222, 28);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(112, 37);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Recherche";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // montant_txt
            // 
            this.montant_txt.Location = new System.Drawing.Point(104, 61);
            this.montant_txt.Name = "montant_txt";
            this.montant_txt.Size = new System.Drawing.Size(98, 23);
            this.montant_txt.TabIndex = 6;
            this.montant_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date Achat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Montant Total";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // achatTable
            // 
            this.achatTable.AllowUserToAddRows = false;
            this.achatTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.achatTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.achatTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.achatTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.achatTable.BackgroundColor = System.Drawing.Color.White;
            this.achatTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.achatTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.achatTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.achatTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.achatTable.ColumnHeadersHeight = 41;
            this.achatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.achatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.DateA,
            this.montant});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.achatTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.achatTable.EnableHeadersVisualStyles = false;
            this.achatTable.Location = new System.Drawing.Point(0, 114);
            this.achatTable.MultiSelect = false;
            this.achatTable.Name = "achatTable";
            this.achatTable.ReadOnly = true;
            this.achatTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.achatTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.achatTable.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.achatTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.achatTable.RowTemplate.Height = 35;
            this.achatTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.achatTable.Size = new System.Drawing.Size(637, 232);
            this.achatTable.TabIndex = 1;
            this.achatTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.achatTable_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // DateA
            // 
            this.DateA.DataPropertyName = "dateAchat";
            this.DateA.HeaderText = "Date Achat";
            this.DateA.Name = "DateA";
            this.DateA.ReadOnly = true;
            // 
            // montant
            // 
            this.montant.DataPropertyName = "montantTotal";
            this.montant.HeaderText = "Montant Total (DA)";
            this.montant.Name = "montant";
            this.montant.ReadOnly = true;
            // 
            // detailsTable
            // 
            this.detailsTable.AllowUserToAddRows = false;
            this.detailsTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.detailsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.detailsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.detailsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.detailsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.detailsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.detailsTable.ColumnHeadersHeight = 45;
            this.detailsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.codeBarre,
            this.Nom,
            this.type,
            this.qnt,
            this.prixA,
            this.prixV,
            this.dateExp,
            this.Fournisseur});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailsTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.detailsTable.EnableHeadersVisualStyles = false;
            this.detailsTable.Location = new System.Drawing.Point(0, 359);
            this.detailsTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.detailsTable.MultiSelect = false;
            this.detailsTable.Name = "detailsTable";
            this.detailsTable.ReadOnly = true;
            this.detailsTable.RowHeadersVisible = false;
            this.detailsTable.RowTemplate.Height = 35;
            this.detailsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsTable.Size = new System.Drawing.Size(637, 276);
            this.detailsTable.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // codeBarre
            // 
            this.codeBarre.DataPropertyName = "codeBarre";
            this.codeBarre.HeaderText = "Code_Barre";
            this.codeBarre.Name = "codeBarre";
            this.codeBarre.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom Article";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "Type ";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // qnt
            // 
            this.qnt.DataPropertyName = "Quantité";
            this.qnt.HeaderText = "Quantité";
            this.qnt.Name = "qnt";
            this.qnt.ReadOnly = true;
            // 
            // prixA
            // 
            this.prixA.DataPropertyName = "prixAchat";
            this.prixA.HeaderText = "prix Achat (DA)";
            this.prixA.Name = "prixA";
            this.prixA.ReadOnly = true;
            // 
            // prixV
            // 
            this.prixV.DataPropertyName = "prixVente";
            this.prixV.HeaderText = "Prix Vente (DA)";
            this.prixV.Name = "prixV";
            this.prixV.ReadOnly = true;
            // 
            // dateExp
            // 
            this.dateExp.DataPropertyName = "dateExpiration";
            this.dateExp.HeaderText = "Date Expiration";
            this.dateExp.Name = "dateExp";
            this.dateExp.ReadOnly = true;
            // 
            // Fournisseur
            // 
            this.Fournisseur.DataPropertyName = "Fournisseur.nom";
            this.Fournisseur.HeaderText = "Nom Fournisseur ";
            this.Fournisseur.Name = "Fournisseur";
            this.Fournisseur.ReadOnly = true;
            // 
            // listeAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(637, 647);
            this.Controls.Add(this.detailsTable);
            this.Controls.Add(this.achatTable);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listeAchat";
            this.Text = "listeAchat";
            this.Load += new System.EventHandler(this.listeAchat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.achatTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView achatTable;
        private System.Windows.Forms.DataGridView detailsTable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox montant_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateA;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixA;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fournisseur;
    }
}