
namespace Gestionnaire_Pro
{
    partial class ajouteFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajouteFournisseur));
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sub_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.credit_txt = new System.Windows.Forms.TextBox();
            this.numTlf_txt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nom_txt
            // 
            this.nom_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nom_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nom_txt.Location = new System.Drawing.Point(219, 121);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(149, 32);
            this.nom_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.Location = new System.Drawing.Point(407, 121);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(144, 42);
            this.sub_btn.TabIndex = 4;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(407, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "N° Téléphone";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // address_txt
            // 
            this.address_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.address_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_txt.Location = new System.Drawing.Point(219, 244);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(206, 112);
            this.address_txt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Credit a Rendre";
            // 
            // credit_txt
            // 
            this.credit_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.credit_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credit_txt.Location = new System.Drawing.Point(219, 370);
            this.credit_txt.Name = "credit_txt";
            this.credit_txt.Size = new System.Drawing.Size(120, 32);
            this.credit_txt.TabIndex = 3;
            this.credit_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.credit_txt_KeyPress);
            // 
            // numTlf_txt
            // 
            this.numTlf_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numTlf_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTlf_txt.Location = new System.Drawing.Point(219, 177);
            this.numTlf_txt.Mask = "00 00 00 00 00 ";
            this.numTlf_txt.Name = "numTlf_txt";
            this.numTlf_txt.Size = new System.Drawing.Size(149, 32);
            this.numTlf_txt.TabIndex = 1;
            // 
            // ajouteFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 508);
            this.Controls.Add(this.numTlf_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.credit_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ajouteFournisseur";
            this.Text = "Nouveau Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox credit_txt;
        private System.Windows.Forms.MaskedTextBox numTlf_txt;
    }
}