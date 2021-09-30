
namespace Gestionnaire_Pro
{
    partial class ajouteClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajouteClient));
            this.numTlf_txt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.credit_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numRegistre_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numTlf_txt
            // 
            this.numTlf_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numTlf_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTlf_txt.Location = new System.Drawing.Point(168, 164);
            this.numTlf_txt.Mask = "00 00 00 00 00 ";
            this.numTlf_txt.Name = "numTlf_txt";
            this.numTlf_txt.Size = new System.Drawing.Size(149, 32);
            this.numTlf_txt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Credit";
            // 
            // credit_txt
            // 
            this.credit_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.credit_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credit_txt.Location = new System.Drawing.Point(168, 357);
            this.credit_txt.Name = "credit_txt";
            this.credit_txt.Size = new System.Drawing.Size(120, 32);
            this.credit_txt.TabIndex = 13;
            this.credit_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.credit_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Address";
            // 
            // address_txt
            // 
            this.address_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.address_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_txt.Location = new System.Drawing.Point(168, 231);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(206, 112);
            this.address_txt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "N° Téléphone";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(345, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.Location = new System.Drawing.Point(345, 93);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(160, 41);
            this.sub_btn.TabIndex = 14;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom";
            // 
            // nom_txt
            // 
            this.nom_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nom_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nom_txt.Location = new System.Drawing.Point(168, 108);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(149, 32);
            this.nom_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "N° Registre";
            // 
            // numRegistre_txt
            // 
            this.numRegistre_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numRegistre_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numRegistre_txt.Location = new System.Drawing.Point(168, 56);
            this.numRegistre_txt.Name = "numRegistre_txt";
            this.numRegistre_txt.Size = new System.Drawing.Size(149, 32);
            this.numRegistre_txt.TabIndex = 0;
            // 
            // ajouteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numRegistre_txt);
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
            this.Name = "ajouteClient";
            this.Text = "Nouveau Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox numTlf_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox credit_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numRegistre_txt;
    }
}