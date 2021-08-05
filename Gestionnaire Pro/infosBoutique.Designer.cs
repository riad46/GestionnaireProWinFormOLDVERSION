
namespace Gestionnaire_Pro
{
    partial class infosBoutique
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
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.numTlf_txt = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.img_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sub_btn = new System.Windows.Forms.Button();
            this.deleteImg_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_txt
            // 
            this.nom_txt.Location = new System.Drawing.Point(194, 69);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(156, 23);
            this.nom_txt.TabIndex = 0;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(194, 129);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(262, 136);
            this.address_txt.TabIndex = 1;
            // 
            // numTlf_txt
            // 
            this.numTlf_txt.Location = new System.Drawing.Point(194, 301);
            this.numTlf_txt.Mask = "00 00 00 00 00 0";
            this.numTlf_txt.Name = "numTlf_txt";
            this.numTlf_txt.Size = new System.Drawing.Size(236, 23);
            this.numTlf_txt.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 176);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // img_btn
            // 
            this.img_btn.Location = new System.Drawing.Point(162, 392);
            this.img_btn.Name = "img_btn";
            this.img_btn.Size = new System.Drawing.Size(26, 28);
            this.img_btn.TabIndex = 4;
            this.img_btn.Text = "+";
            this.img_btn.UseVisualStyleBackColor = true;
            this.img_btn.Click += new System.EventHandler(this.img_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom Boutique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "N° Téléphone";
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(502, 36);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(129, 38);
            this.sub_btn.TabIndex = 8;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // deleteImg_btn
            // 
            this.deleteImg_btn.Location = new System.Drawing.Point(162, 457);
            this.deleteImg_btn.Name = "deleteImg_btn";
            this.deleteImg_btn.Size = new System.Drawing.Size(26, 28);
            this.deleteImg_btn.TabIndex = 9;
            this.deleteImg_btn.Text = "-";
            this.deleteImg_btn.UseVisualStyleBackColor = true;
            this.deleteImg_btn.Click += new System.EventHandler(this.deleteImg_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logo";
            // 
            // infosBoutique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteImg_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numTlf_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.nom_txt);
            this.Name = "infosBoutique";
            this.Text = "infosBoutique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.infosBoutique_FormClosing);
            this.Load += new System.EventHandler(this.infosBoutique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.MaskedTextBox numTlf_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button img_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button deleteImg_btn;
        private System.Windows.Forms.Label label4;
    }
}