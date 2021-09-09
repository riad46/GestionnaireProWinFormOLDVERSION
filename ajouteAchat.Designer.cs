
namespace Gestionnaire_Pro
{
    partial class ajouteAchat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajouteAchat));
            this.articleTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.modifyArticles_checkbox = new System.Windows.Forms.CheckBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.ajoutArticle_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prixV_txt = new System.Windows.Forms.TextBox();
            this.prixA_txt = new System.Windows.Forms.TextBox();
            this.qnt_txt = new System.Windows.Forms.TextBox();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.codeBarre_txt = new System.Windows.Forms.TextBox();
            this.fournisseurs_combo = new System.Windows.Forms.ComboBox();
            this.dateExp_box = new System.Windows.Forms.DateTimePicker();
            this.dateAchat_box = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
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
            this.articleTable.BackgroundColor = System.Drawing.Color.White;
            this.articleTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.articleTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articleTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articleTable.ColumnHeadersHeight = 45;
            this.articleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codeBarre,
            this.nom,
            this.type,
            this.qnt,
            this.prixAchat,
            this.prixVente,
            this.dateExp,
            this.fournisseur});
            this.articleTable.Location = new System.Drawing.Point(0, 235);
            this.articleTable.MultiSelect = false;
            this.articleTable.Name = "articleTable";
            this.articleTable.ReadOnly = true;
            this.articleTable.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.articleTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.articleTable.RowTemplate.Height = 35;
            this.articleTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articleTable.Size = new System.Drawing.Size(981, 268);
            this.articleTable.TabIndex = 22;
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
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // qnt
            // 
            this.qnt.DataPropertyName = "quantité";
            this.qnt.HeaderText = "Quantité";
            this.qnt.Name = "qnt";
            this.qnt.ReadOnly = true;
            // 
            // prixAchat
            // 
            this.prixAchat.DataPropertyName = "prixAchat";
            this.prixAchat.HeaderText = "Prix Achat";
            this.prixAchat.Name = "prixAchat";
            this.prixAchat.ReadOnly = true;
            // 
            // prixVente
            // 
            this.prixVente.DataPropertyName = "prixVente";
            this.prixVente.HeaderText = "Prix de Vente";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.type_txt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.modifyArticles_checkbox);
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Controls.Add(this.sub_btn);
            this.panel1.Controls.Add(this.ajoutArticle_btn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.prixV_txt);
            this.panel1.Controls.Add(this.prixA_txt);
            this.panel1.Controls.Add(this.qnt_txt);
            this.panel1.Controls.Add(this.nom_txt);
            this.panel1.Controls.Add(this.codeBarre_txt);
            this.panel1.Controls.Add(this.fournisseurs_combo);
            this.panel1.Controls.Add(this.dateExp_box);
            this.panel1.Controls.Add(this.dateAchat_box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 229);
            this.panel1.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(436, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Type";
            // 
            // type_txt
            // 
            this.type_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type_txt.Location = new System.Drawing.Point(481, 43);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(138, 26);
            this.type_txt.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(459, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Fournisseur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(192, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Date Expiration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Prix Vente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(813, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 58;
            this.label4.Text = "Prix Achat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(655, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quantité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(229, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "Code Barre";
            // 
            // modifyArticles_checkbox
            // 
            this.modifyArticles_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyArticles_checkbox.AutoSize = true;
            this.modifyArticles_checkbox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modifyArticles_checkbox.Location = new System.Drawing.Point(708, 154);
            this.modifyArticles_checkbox.Name = "modifyArticles_checkbox";
            this.modifyArticles_checkbox.Size = new System.Drawing.Size(245, 26);
            this.modifyArticles_checkbox.TabIndex = 54;
            this.modifyArticles_checkbox.Text = "Modifier la Liste d\'articles";
            this.modifyArticles_checkbox.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_btn.Location = new System.Drawing.Point(12, 198);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(162, 28);
            this.del_btn.TabIndex = 53;
            this.del_btn.Text = "Supprimer Ligne";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sub_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.ForeColor = System.Drawing.Color.White;
            this.sub_btn.Location = new System.Drawing.Point(708, 186);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(261, 40);
            this.sub_btn.TabIndex = 52;
            this.sub_btn.Text = "Valider Achat";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // ajoutArticle_btn
            // 
            this.ajoutArticle_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ajoutArticle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ajoutArticle_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ajoutArticle_btn.Location = new System.Drawing.Point(682, 92);
            this.ajoutArticle_btn.Name = "ajoutArticle_btn";
            this.ajoutArticle_btn.Size = new System.Drawing.Size(175, 25);
            this.ajoutArticle_btn.TabIndex = 51;
            this.ajoutArticle_btn.Text = "Ajouter au Tableau";
            this.ajoutArticle_btn.UseVisualStyleBackColor = false;
            this.ajoutArticle_btn.Click += new System.EventHandler(this.ajoutArticle_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(219, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 28);
            this.button2.TabIndex = 50;
            this.button2.Text = "Liste d\'Articles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ListArticle_Click);
            // 
            // prixV_txt
            // 
            this.prixV_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prixV_txt.Location = new System.Drawing.Point(87, 90);
            this.prixV_txt.Name = "prixV_txt";
            this.prixV_txt.Size = new System.Drawing.Size(87, 26);
            this.prixV_txt.TabIndex = 49;
            this.prixV_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixV_txt_KeyPress);
            // 
            // prixA_txt
            // 
            this.prixA_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prixA_txt.Location = new System.Drawing.Point(893, 43);
            this.prixA_txt.Name = "prixA_txt";
            this.prixA_txt.Size = new System.Drawing.Size(85, 26);
            this.prixA_txt.TabIndex = 48;
            this.prixA_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixA_txt_KeyPress);
            // 
            // qnt_txt
            // 
            this.qnt_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qnt_txt.Location = new System.Drawing.Point(732, 41);
            this.qnt_txt.Name = "qnt_txt";
            this.qnt_txt.Size = new System.Drawing.Size(75, 26);
            this.qnt_txt.TabIndex = 47;
            this.qnt_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qnt_txt_KeyPress);
            // 
            // nom_txt
            // 
            this.nom_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nom_txt.Location = new System.Drawing.Point(274, 43);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(138, 26);
            this.nom_txt.TabIndex = 46;
            // 
            // codeBarre_txt
            // 
            this.codeBarre_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeBarre_txt.Location = new System.Drawing.Point(88, 46);
            this.codeBarre_txt.Name = "codeBarre_txt";
            this.codeBarre_txt.Size = new System.Drawing.Size(135, 26);
            this.codeBarre_txt.TabIndex = 45;
            // 
            // fournisseurs_combo
            // 
            this.fournisseurs_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fournisseurs_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fournisseurs_combo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fournisseurs_combo.FormattingEnabled = true;
            this.fournisseurs_combo.Location = new System.Drawing.Point(553, 90);
            this.fournisseurs_combo.Name = "fournisseurs_combo";
            this.fournisseurs_combo.Size = new System.Drawing.Size(123, 27);
            this.fournisseurs_combo.Sorted = true;
            this.fournisseurs_combo.TabIndex = 44;
            // 
            // dateExp_box
            // 
            this.dateExp_box.CustomFormat = "dd-MM-yyyy";
            this.dateExp_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateExp_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExp_box.Location = new System.Drawing.Point(313, 89);
            this.dateExp_box.Name = "dateExp_box";
            this.dateExp_box.Size = new System.Drawing.Size(125, 26);
            this.dateExp_box.TabIndex = 43;
            // 
            // dateAchat_box
            // 
            this.dateAchat_box.CustomFormat = "dd-MM-yyyy";
            this.dateAchat_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateAchat_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAchat_box.Location = new System.Drawing.Point(88, 3);
            this.dateAchat_box.Name = "dateAchat_box";
            this.dateAchat_box.Size = new System.Drawing.Size(125, 26);
            this.dateAchat_box.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date Achat";
            this.label1.UseWaitCursor = true;
            // 
            // ajouteAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.articleTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ajouteAchat";
            this.Text = "Nouvelle Achat";
            this.Load += new System.EventHandler(this.ajouteAchat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView articleTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateAchat_box;
        private System.Windows.Forms.TextBox prixV_txt;
        private System.Windows.Forms.TextBox prixA_txt;
        private System.Windows.Forms.TextBox qnt_txt;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.TextBox codeBarre_txt;
        private System.Windows.Forms.ComboBox fournisseurs_combo;
        private System.Windows.Forms.DateTimePicker dateExp_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox modifyArticles_checkbox;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button ajoutArticle_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fournisseur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox type_txt;
        //  private GradiantPanel gradiantPanel1;
    }
}