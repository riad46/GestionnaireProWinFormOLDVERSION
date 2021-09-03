
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
            this.SuspendLayout();
            // 
            // numTlf_txt
            // 
            this.numTlf_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numTlf_txt.Location = new System.Drawing.Point(151, 97);
            this.numTlf_txt.Mask = "00 00 00 00 00 ";
            this.numTlf_txt.Name = "numTlf_txt";
            this.numTlf_txt.Size = new System.Drawing.Size(149, 29);
            this.numTlf_txt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Credit";
            // 
            // credit_txt
            // 
            this.credit_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.credit_txt.Location = new System.Drawing.Point(151, 290);
            this.credit_txt.Name = "credit_txt";
            this.credit_txt.Size = new System.Drawing.Size(120, 29);
            this.credit_txt.TabIndex = 13;
            this.credit_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.credit_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Address";
            // 
            // address_txt
            // 
            this.address_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address_txt.Location = new System.Drawing.Point(151, 164);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(206, 112);
            this.address_txt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "N° Téléphone";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(400, 41);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(112, 35);
            this.sub_btn.TabIndex = 14;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom";
            // 
            // nom_txt
            // 
            this.nom_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nom_txt.Location = new System.Drawing.Point(151, 41);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(149, 29);
            this.nom_txt.TabIndex = 10;
            // 
            // ajouteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 385);
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
            this.Name = "ajouteClient";
            this.Text = "ajouteClient";
            this.Load += new System.EventHandler(this.ajouteClient_Load);
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
    }
}