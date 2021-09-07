
namespace Gestionnaire_Pro
{
    partial class ajouteArticle
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
            this.codeBarre_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qnt_txt = new System.Windows.Forms.TextBox();
            this.lebel452 = new System.Windows.Forms.Label();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prixVente_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prixAchat_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Fournisseur_combo = new System.Windows.Forms.ComboBox();
            this.sub_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateExp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // codeBarre_txt
            // 
            this.codeBarre_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeBarre_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeBarre_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeBarre_txt.Location = new System.Drawing.Point(217, 66);
            this.codeBarre_txt.Name = "codeBarre_txt";
            this.codeBarre_txt.Size = new System.Drawing.Size(168, 29);
            this.codeBarre_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "CodeBarre";
            // 
            // nom_txt
            // 
            this.nom_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nom_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nom_txt.Location = new System.Drawing.Point(217, 112);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(168, 29);
            this.nom_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // qnt_txt
            // 
            this.qnt_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.qnt_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qnt_txt.Location = new System.Drawing.Point(217, 200);
            this.qnt_txt.Name = "qnt_txt";
            this.qnt_txt.Size = new System.Drawing.Size(105, 29);
            this.qnt_txt.TabIndex = 10;
            this.qnt_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qnt_txt_KeyPress);
            // 
            // lebel452
            // 
            this.lebel452.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lebel452.AutoSize = true;
            this.lebel452.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lebel452.Location = new System.Drawing.Point(24, 200);
            this.lebel452.Name = "lebel452";
            this.lebel452.Size = new System.Drawing.Size(103, 26);
            this.lebel452.TabIndex = 9;
            this.lebel452.Text = "Quantité";
            // 
            // type_txt
            // 
            this.type_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type_txt.Location = new System.Drawing.Point(217, 154);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(140, 29);
            this.type_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type de Produit";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fournisseur";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date d\'Expiration";
            // 
            // prixVente_txt
            // 
            this.prixVente_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prixVente_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prixVente_txt.Location = new System.Drawing.Point(217, 286);
            this.prixVente_txt.Name = "prixVente_txt";
            this.prixVente_txt.Size = new System.Drawing.Size(121, 29);
            this.prixVente_txt.TabIndex = 14;
            this.prixVente_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixVente_txt_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prix de Vente";
            // 
            // prixAchat_txt
            // 
            this.prixAchat_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prixAchat_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prixAchat_txt.Location = new System.Drawing.Point(217, 240);
            this.prixAchat_txt.Name = "prixAchat_txt";
            this.prixAchat_txt.Size = new System.Drawing.Size(121, 29);
            this.prixAchat_txt.TabIndex = 12;
            this.prixAchat_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixAchat_txt_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Prix d\'Achat";
            // 
            // Fournisseur_combo
            // 
            this.Fournisseur_combo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fournisseur_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Fournisseur_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Fournisseur_combo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fournisseur_combo.FormattingEnabled = true;
            this.Fournisseur_combo.Location = new System.Drawing.Point(217, 369);
            this.Fournisseur_combo.Name = "Fournisseur_combo";
            this.Fournisseur_combo.Size = new System.Drawing.Size(215, 29);
            this.Fournisseur_combo.TabIndex = 20;
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sub_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.Location = new System.Drawing.Point(439, 66);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(147, 46);
            this.sub_btn.TabIndex = 21;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = false;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(438, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 22;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dateExp
            // 
            this.dateExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateExp.CustomFormat = "dd/MM/yyyy";
            this.dateExp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateExp.Location = new System.Drawing.Point(217, 328);
            this.dateExp.Name = "dateExp";
            this.dateExp.Size = new System.Drawing.Size(121, 27);
            this.dateExp.TabIndex = 23;
            // 
            // ajouteArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 428);
            this.Controls.Add(this.dateExp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.Fournisseur_combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prixVente_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prixAchat_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.qnt_txt);
            this.Controls.Add(this.lebel452);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nom_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeBarre_txt);
            this.Controls.Add(this.label1);
            this.Name = "ajouteArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau Article";
            this.Load += new System.EventHandler(this.ajouteArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox codeBarre_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qnt_txt;
        private System.Windows.Forms.Label lebel452;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prixVente_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prixAchat_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Fournisseur_combo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sub_btn;
    
        private System.Windows.Forms.DateTimePicker dateExp;
    }
}